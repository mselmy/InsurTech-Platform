export class MotorinsuranceModule {
  constructor(
    public yearlyCoverage: number,
    public level: number,  
    public quotation: number,
    public personalAccident: number,
    public theft: number,
    public thirdPartyLiability: number,
    public ownDamage: number,
    public legalExpenses: number,
    public id: number,
    public companyId: number,
    public categoryId: number
  ) {}
  
 }