// Models/OrderViewModel.cs
public class OrderViewModel {
    public string OrderId { get; set; }
    public long Amount { get; set; }
    // 消費税計算アルゴリズムはここに隠蔽（分離）
    public long TotalAmount => (long)(Amount * 1.1);
}