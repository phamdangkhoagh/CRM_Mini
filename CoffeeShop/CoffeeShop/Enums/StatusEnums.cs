namespace CoffeeShop.Enums
{
    public class StatusEnums
    {
        public enum OrderStatus
        {
            Pending = 0,
            Processing = 1,
            Completed = 2,
            Cancelled = 3
        }

        public enum UserStatus
        {
            Inactive = 0,
            Active = 1,
            Banned = 2
        }

        public enum PaymentStatus
        {
            Pending = 0,
            Success = 1,
            Failed = 2
        }

        public enum NotificationStatus
        {
            Coupon = 0,
            Payment = 1,
        }

        public enum RoleStatus
        {
            Inactive = 0,
            Active = 1
        }

        public enum ProductStatus
        {
            Unavailable = 0,
            Available = 1,
            OutOfStock = 2,
            Discontinued = 3
        }

        public enum CategoryStatus
        {
            Inactive = 0,
            Active = 1
        }

        public enum CouponStatus
        {
            Inactive = 0,
            Active = 1,
            Expired = 2
        }

        public enum CouponDetailStatus
        {
            Unused = 0,
            Used = 1
        }

        public enum SizeProduct
        {
            Small = 0,
            Medium = 1,
            Large = 2,
            ExtraLarge = 3
        }
    }
}
