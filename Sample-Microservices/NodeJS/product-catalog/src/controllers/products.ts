/** src/controllers/products.ts */
import { Request, Response, NextFunction } from "express";
import axios, { AxiosResponse } from "axios";
import { ProductsRepository } from "../data/product.repository";
import { Product } from "../models/product.model";
import { Price } from "../models/price.model";

const repository = new ProductsRepository();

// getting all posts
const getProducts = async (req: Request, res: Response, next: NextFunction) => {
  // get the prices, products and match them up
  let prices = await getPrices();
  let products = repository.GetAllProducts();

  assignPrices(products, prices);

  return res.status(200).json(repository.GetAllProducts());
};

// getting a single post
const getProduct = async (req: Request, res: Response, next: NextFunction) => {
  // get the post id from the req
  let id: string = req.params.sku;
  let price = await getPrice(id);
  let product = repository.GetProduct(id);
  product.setPrice(price);

  return res.status(200).json(product);
};

//private functions

const assignPrices = (products: Product[], prices: Price[]) => {
  products.forEach((each) => {
    let price = prices.find((obj) => {
      return obj.sku === each.sku;
    }) as Price;
    each.setPrice(price);
  });
};

const getPrices = async () => {
  let result: AxiosResponse = await axios.get(`http://localhost:6061/prices`);
  let prices: Price[] = result.data;
  return prices;
};

const getPrice = async (sku: String) => {
  let result: AxiosResponse = await axios.get(
    `http://localhost:6061/prices/${sku}`
  );
  let price: Price = result.data;
  return price;
};

export default { getProducts, getProduct };
