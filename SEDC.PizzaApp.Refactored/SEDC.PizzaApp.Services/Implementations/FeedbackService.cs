using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.Mappers;
using System.Linq;
using SEDC.PizzaApp.Shared.CustomExceptions;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;

        public FeedbackService(IRepository<Feedback> feedbackRepository) //Dependency Injection
        {
            _feedbackRepository = feedbackRepository;
        }
        public void DeleteFeedback(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new Exception($"The feedback with id {id} was not found!");
            }
            _feedbackRepository.DeleteById(id);
        }

        public void EditFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(feedbackViewModel.Id);
            if (feedbackDb == null)
            {
                throw new Exception($"The feedback with id {feedbackViewModel.Id} was not found!");
            }
            Feedback editedFeedback = feedbackViewModel.ToFeedback();
            editedFeedback.Id = feedbackViewModel.Id;
            editedFeedback.Name = feedbackViewModel.Name;
            editedFeedback.Email = feedbackViewModel.Email;
            editedFeedback.Message = feedbackViewModel.Message;
            _feedbackRepository.Update(editedFeedback);
        }

        public List<FeedbackListViewModel> GetAllFeedbacks()
        {
            List<Feedback> dbFeedbacks = _feedbackRepository.GetAll();
            return dbFeedbacks.Select(x => FeedbackMapper.FeedbackToFeedbackListViewModel(x)).ToList();
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new Exception($"The feedback with id {id} was not found!");
            }
            return feedbackDb.ToFeedbackDetailsViewModel();
        }

        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new ResourceNotFoundException($"The feedback with id {id} was not found");
            }

            return feedbackDb.ToFeedbackViewModel();
        }

        public void InsertFeedback(FeedbackViewModel feedbackViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.ToFeedback()).Email).ToList();

            if (feedbacks.Count < 3)
            {
                Feedback feedback = feedbackViewModel.ToFeedback();

                int newFeedbackId = _feedbackRepository.Insert(feedback);
                if (newFeedbackId <= 0)
                {
                    throw new Exception("An error occured while saving to db");
                }
            }
            else
            {
                throw new Exception("You've reached your limits for posting feedbacks!");
            }
        }
    }
}
