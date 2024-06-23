import { Order } from "../order/Order";

export type Customer = {
  id: string;
  createdAt: Date;
  updatedAt: Date;
  name: string | null;
  lastName: string | null;
  orders?: Array<Order>;
};
