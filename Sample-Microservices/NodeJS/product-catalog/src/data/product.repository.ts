import { Product } from "../models/product.model";

export class ProductsRepository {
  latte = new Product(
    "d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d",
    "Flat White Latte",
    "Our most popular Latte",
    "Coffee-Bucks"
  );
  spice = new Product(
    "c0c20648-ecd9-4896-999d-8c2d55010f77",
    "Pumpkin Spice Latte",
    "Our favorite Latte for Halloween",
    "Coffee-Bucks"
  );

  brownee = new Product(
    "76ad06f0-8ced-401e-862d-da27b1b496bb",
    "Chocolate Fudge Brownee",
    "Try our most popular Brownee",
    "Jim-Hortons"
  );

  all = [this.latte, this.spice, this.brownee];

  GetAllProducts(): Product[] {
    return this.all;
  }

  GetProduct(id: string): Product {
    const result = this.all.find((obj) => {
      return obj.sku === id;
    });
    return result as Product;
  }
}
