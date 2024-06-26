using System.ComponentModel.DataAnnotations;

namespace GameStore.Api;

public record GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price, 
    DateTime ReleaseDate,
    string ImageUri
);

public record CreateGameDto(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(25)]string Genre,
    [Range(1,100)]decimal Price,
    DateTime ReleaseDate,
    [Url][StringLength(100)]string ImageUri
);

public record UpdateGameDto(
    string Name,
    string Genre,
    decimal Price,
    DateTime ReleaseDate,
    string ImageUri
);