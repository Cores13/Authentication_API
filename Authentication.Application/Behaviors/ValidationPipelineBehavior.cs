using Authentication.Domain.Core.Primitives;
using FluentValidation;
using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Behaviors
{
    public class ValidationPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TResponse : Result
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken = default)
        {
            if (!_validators.Any())
            {
                return await next();
            }

            var context = new ValidationContext<TRequest>(request);

            var validationResults = await Task.WhenAll(
                _validators.Select(v => v.ValidateAsync(context, cancellationToken))
            );

            var failures = validationResults
                .SelectMany(r => r.Errors)
                .Where(f => f is not null)
                .ToList();

            if (failures.Count != 0)
            {
                var errors = failures
                    .Select(failure => new Error(
                        failure.PropertyName,
                        failure.ErrorMessage))
                    .Distinct()
                    .ToArray();

                return CreateValidationResult<TResponse>(errors);
            }

            return await next();
        }

        private static TResult CreateValidationResult<TResult>(Error[] errors)
            where TResult : Result
        {
            if (typeof(TResult) == typeof(Result))
            {
                return (ValidationResult.WithErrors(errors) as TResult)!;
            }

            if (typeof(TResult).IsGenericType && typeof(TResult).GetGenericTypeDefinition() == typeof(Result<>))
            {
                var genericType = typeof(TResult).GenericTypeArguments[0];
                var method = typeof(ValidationResult<>)
                    .MakeGenericType(genericType)
                    .GetMethod(nameof(ValidationResult.WithErrors));

                var validationResult = method!.Invoke(null, new object?[] { errors });
                return (TResult)validationResult!;
            }

            throw new InvalidOperationException($"Invalid result type: {typeof(TResult)}");
        }
    }
}
