package com.xerris.sre.products;

import com.xerris.sre.products.domain.Product;
import com.xerris.sre.products.services.IProductsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.UUID;

@Controller
public class ProductCatalogController {
    private final IProductsService service;

    @Autowired
    public ProductCatalogController(IProductsService service) {
        this.service = service;
    }

    @GetMapping("/products")
    public @ResponseBody Product[] getAllProducts() {
        return service.getAllProducts();
    }

    @GetMapping("/products/{sku}")
    public @ResponseBody Product getPrice(@PathVariable String sku) {
        UUID priceSku = UUID.fromString(sku);
        return service.getProduct(priceSku);
    }
}
