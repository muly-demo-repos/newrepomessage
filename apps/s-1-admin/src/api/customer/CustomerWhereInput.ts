import { StringFilter } from "../../util/StringFilter";
import { StringNullableFilter } from "../../util/StringNullableFilter";
import { OrderListRelationFilter } from "../order/OrderListRelationFilter";
import { DecimalNullableFilter } from "../../util/DecimalNullableFilter";

export type CustomerWhereInput = {
  id?: StringFilter;
  name?: StringNullableFilter;
  lastName?: StringNullableFilter;
  orders?: OrderListRelationFilter;
  numero?: DecimalNullableFilter;
};
