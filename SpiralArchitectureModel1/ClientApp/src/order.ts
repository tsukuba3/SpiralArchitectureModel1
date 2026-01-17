// ClientApp/src/order.ts
interface OrderInfo {
    orderId: string;
    totalAmount: number;
}

export const updateOrderDisplay = (data: OrderInfo) => {
    const el = document.getElementById("order-status");
    if (el) {
        el.innerText = `${data.orderId}の確定金額: ￥${data.totalAmount}`;
    }
};