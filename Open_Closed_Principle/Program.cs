
#region Not Ideal Code
OCP_NotIdealCode.MoneySender moneySender1 = new();
moneySender1.Send(1000);
#endregion

#region Ideal Code
OCP_IdealCode.MoneySender moneySender = new();
moneySender.Send(new OCP_IdealCode.Halkbank(), 1000, "TR 15425544514755004");

moneySender.Send(new OCP_IdealCode.Garanti(), 2500, "TR 25485456300000005");

moneySender.Send(new OCP_IdealCode.HalilBank(), 3800, "TR 25485456300000005");
#endregion