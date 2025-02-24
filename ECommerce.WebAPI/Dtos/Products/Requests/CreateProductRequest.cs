﻿namespace ECommerce.WebAPI.Dtos.Products.Requests;

public sealed record CreateProductRequest
    (
    string Name,
    int Stock,
    decimal Price,
   int CategoryId
    );

