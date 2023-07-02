namespace BurberBreakfast.Contracts.Breakfast;

public record BreakfastRespose(
 Guid Id,
 string Name,
 string Description,
 DateTime StartDateTime,
 DateTime EndDateTime,
 DateTime LastModifiedDateTime,
 List<string> Savory,
 List<string> sweet);