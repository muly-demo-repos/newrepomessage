import { Order } from "../order/Order";
import { Decimal } from "decimal.js";

export type Customer = {
  id: string;
  createdAt: Date;
  updatedAt: Date;
  name: string | null;
  lastName: string | null;
  orders?: Array<Order>;
  numero: Decimal | null;
};
