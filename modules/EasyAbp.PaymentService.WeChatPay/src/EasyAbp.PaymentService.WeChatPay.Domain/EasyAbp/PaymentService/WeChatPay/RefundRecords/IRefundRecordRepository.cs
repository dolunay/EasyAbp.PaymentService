using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.PaymentService.WeChatPay.RefundRecords
{
    public interface IRefundRecordRepository : IRepository<RefundRecord, Guid>
    {
        Task<RefundRecord> FindByOutRefundNoAsync([NotNull] string outRefundNo);
    }
}