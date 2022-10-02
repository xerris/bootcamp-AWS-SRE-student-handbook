import { Price } from "../models/price.model";

export class ProductsRepository {
  latte = new Price("d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d", 5.75, 3);
  spice = new Price("c0c20648-ecd9-4896-999d-8c2d55010f77", 5.75, 3.15);
  brownee = new Price("76ad06f0-8ced-401e-862d-da27b1b496bb", 4.25, 2.75);

  all = [this.latte, this.spice, this.brownee];

  getAllPrices(): Price[] {
    return this.all;
  }

  GetProduct(id: string): Price {
    const result = this.all.find((obj) => {
      return obj.sku === id;
    });
    return result as Price;
  }
}
