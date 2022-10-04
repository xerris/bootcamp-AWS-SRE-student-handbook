package com.xerris.sre.products.services;

import com.xerris.sre.products.domain.Product;
import java.util.UUID;

public interface IProductsService {
    Product[] getAllProducts();
    Product getProduct(UUID sku);
}
