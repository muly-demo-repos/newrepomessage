import { CustomerWhereUniqueInput } from "../customer/CustomerWhereUniqueInput";

export type OrderCreateInput = {
  description?: string | null;
  customer?: CustomerWhereUniqueInput | null;
};
