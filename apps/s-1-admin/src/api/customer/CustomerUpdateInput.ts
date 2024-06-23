import { OrderUpdateManyWithoutCustomersInput } from "./OrderUpdateManyWithoutCustomersInput";

export type CustomerUpdateInput = {
  name?: string | null;
  lastName?: string | null;
  orders?: OrderUpdateManyWithoutCustomersInput;
};
