/** source/routes/prices.ts */
import express from "express";
import controller from "../controllers/prices";
const router = express.Router();

router.get("/prices", controller.getPrices);
router.get("/prices/:sku", controller.getPrice);

export = router;
