using Reservation.Review.Dtos;

namespace Reservation.Review.Services
{
    public interface IUserReviewService
    {
        Task<List<ResultUserReviewDto>> GetAllUserReviewAsync();
        Task CreateUserReviewAsync(CreateUserReviewDto createUserReviewDto);
        Task UpdateUserReviewAsync(UpdateUserReviewDto updateUserReviewDto);
        Task DeleteUserReviewAsync(int id);
        Task<GetByIdUserReviewDto> GetUserReviewByIdAsync(int id);

    }
}
