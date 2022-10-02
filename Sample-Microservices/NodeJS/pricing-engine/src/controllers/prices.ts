/** src/controllers/prices.ts */
import { Request, Response, NextFunction } from "express";
import { ProductsRepository } from "../data/price.repository";

interface Post {
  userId: Number;
  id: Number;
  title: String;
  body: String;
}

const repository = new ProductsRepository();

// getting all posts
const getPrices = async (req: Request, res: Response, next: NextFunction) => {
  // // get some posts
  return res.status(200).json(repository.getAllPrices());
};

// getting a single post
const getPrice = async (req: Request, res: Response, next: NextFunction) => {
  // get the post id from the req
  let id: string = req.params.sku;
  // get the post
  return res.status(200).json({
    message: repository.GetProduct(id),
  });
};

export default { getPrices, getPrice };
