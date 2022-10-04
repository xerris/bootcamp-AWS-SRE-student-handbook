package com.xerris.pricing.engine;

import com.xerris.pricing.engine.domain.Price;
import com.xerris.pricing.engine.services.IPricingService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.UUID;

@Controller()
public class PricingController {

    private final IPricingService service;

    @Autowired
    public PricingController(IPricingService service) {
        this.service = service;
    }

    @GetMapping("/prices")
    public @ResponseBody Price[] getAllPrices() {
        return service.getAllPrices();
    }

    @GetMapping("/price/{sku}")
    public @ResponseBody Price getPrice(@PathVariable String sku) {
        UUID priceSku = UUID.fromString(sku);
        return service.getPrice(priceSku);
    }
}