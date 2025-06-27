using static System.Net.Mime.MediaTypeNames;

namespace ChainOfResponsibility
{
    public abstract class DiscountHandler
    {
        protected DiscountHandler? next;

        public void SetNext(DiscountHandler nextHandler) => next = nextHandler;

        public Order Handle(Order order)
        {
            // Chain Of Responsibility "classic"

            //if (CanHandle(order))
            //{
            //    return ApplyDiscount(order);
            //}
            //else if (Next is not null)
            //{
            //    return Next.Handle(order);
            //}
            //else
            //{
            //    return order;
            //}

            // Chain Of Responsibility "modified" - combines handlers
            if (next is null && CanHandle(order))
            {
                return ApplyDiscount(order);
            }
            if (next is null && !CanHandle(order))
            {
                return order;
            }

            if (CanHandle(order))
            {
                return next!.Handle(ApplyDiscount(order));
            }
            else
            {
                return next!.Handle(order);
            }
        }

        public abstract Order ApplyDiscount(Order order);

        public abstract bool CanHandle(Order order);
    }
}
