import { StringFilter } from "../../util/StringFilter";
import { StringNullableFilter } from "../../util/StringNullableFilter";
import { CustomerWhereUniqueInput } from "../customer/CustomerWhereUniqueInput";

export type OrderWhereInput = {
  id?: StringFilter;
  description?: StringNullableFilter;
  customer?: CustomerWhereUniqueInput;
};
