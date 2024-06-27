import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { MosheModuleBase } from "./base/moshe.module.base";
import { MosheService } from "./moshe.service";
import { MosheController } from "./moshe.controller";
import { MosheResolver } from "./moshe.resolver";

@Module({
  imports: [MosheModuleBase, forwardRef(() => AuthModule)],
  controllers: [MosheController],
  providers: [MosheService, MosheResolver],
  exports: [MosheService],
})
export class MosheModule {}
