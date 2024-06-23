import { CustomerWhereUniqueInput } from "../customer/CustomerWhereUniqueInput";

export type OrderUpdateInput = {
  description?: string | null;
  customer?: CustomerWhereUniqueInput | null;
};
