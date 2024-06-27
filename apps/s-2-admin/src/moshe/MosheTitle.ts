import { Moshe as TMoshe } from "../api/moshe/Moshe";

export const MOSHE_TITLE_FIELD = "id";

export const MosheTitle = (record: TMoshe): string => {
  return record.id?.toString() || String(record.id);
};
