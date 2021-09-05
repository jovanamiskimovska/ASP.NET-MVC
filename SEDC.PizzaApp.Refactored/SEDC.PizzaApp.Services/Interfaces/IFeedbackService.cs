using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackListViewModel> GetAllFeedbacks();
        FeedbackDetailsViewModel GetFeedbackDetails(int id);
        void InsertFeedback(FeedbackViewModel feedbackViewModel);
        FeedbackViewModel GetFeedbackForEditing(int id);
        void EditFeedback(FeedbackViewModel feedbackViewModel);
        void DeleteFeedback(int id);

    }
}
