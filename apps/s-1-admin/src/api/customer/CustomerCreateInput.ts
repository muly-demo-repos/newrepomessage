import { OrderCreateNestedManyWithoutCustomersInput } from "./OrderCreateNestedManyWithoutCustomersInput";
import { Decimal } from "decimal.js";

export type CustomerCreateInput = {
  name?: string | null;
  lastName?: string | null;
  orders?: OrderCreateNestedManyWithoutCustomersInput;
  numero?: Decimal | null;
};
