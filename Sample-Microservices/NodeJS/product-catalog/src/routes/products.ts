/** source/routes/products.ts */
import express from "express";
import controller from "../controllers/products";
const router = express.Router();

router.get("/products", controller.getProducts);
router.get("/products/:sku", controller.getProduct);

export = router;
