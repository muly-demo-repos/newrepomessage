import { MosheWhereInput } from "./MosheWhereInput";
import { MosheOrderByInput } from "./MosheOrderByInput";

export type MosheFindManyArgs = {
  where?: MosheWhereInput;
  orderBy?: Array<MosheOrderByInput>;
  skip?: number;
  take?: number;
};
