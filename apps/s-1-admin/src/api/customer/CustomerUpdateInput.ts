import { OrderUpdateManyWithoutCustomersInput } from "./OrderUpdateManyWithoutCustomersInput";
import { Decimal } from "decimal.js";

export type CustomerUpdateInput = {
  name?: string | null;
  lastName?: string | null;
  orders?: OrderUpdateManyWithoutCustomersInput;
  numero?: Decimal | null;
};
