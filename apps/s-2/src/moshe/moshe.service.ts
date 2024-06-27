import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { MosheServiceBase } from "./base/moshe.service.base";

@Injectable()
export class MosheService extends MosheServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
