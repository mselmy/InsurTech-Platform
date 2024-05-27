export class MotorinsuranceModule {
  constructor(
    public yearlyCoverage: number,
    public level: number,
    public categoryName:string,
    public quotation: number,
    public companyName: string,
    public personalAccident: number,
    public theft: number,
    public thirdPartyLiability: number,
    public ownDamage: number,
    public legalExpenses: number,
    public requestNumber: number,
    public id: number
  ) {}
  
 }