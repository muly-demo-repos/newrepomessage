import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { MosheService } from "./moshe.service";
import { MosheControllerBase } from "./base/moshe.controller.base";

@swagger.ApiTags("moshes")
@common.Controller("moshes")
export class MosheController extends MosheControllerBase {
  constructor(
    protected readonly service: MosheService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
