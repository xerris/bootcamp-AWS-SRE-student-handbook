export class Price {
  constructor(
    private sku: string,
    private retailPrice: number,
    private wholesalePrice: number,
  ) {}
}

export class Product {
  public sku: string;
  public name: string;
  public description: string;
  public manufacturer: string;
  public price: Price;
  constructor(
    sku: string,
    name: string,
    description: string,
    manufacturer: string,
  ) {
    this.sku = sku;
    this.name = name;
    this.description = description;
    this.manufacturer = manufacturer;
  }
}
