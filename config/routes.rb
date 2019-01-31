Rails.application.routes.draw do
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html

  root 'students#create'
  get 'students/create'
  get 'students/read'
  get 'students/update'
  get 'students/delete'
end
