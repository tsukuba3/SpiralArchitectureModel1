export const updateOrderDisplay = (data) => {
    const el = document.getElementById("order-status");
    if (el) {
        el.innerText = `${data.orderId}の確定金額: ￥${data.totalAmount}`;
    }
};
//# sourceMappingURL=order.js.map