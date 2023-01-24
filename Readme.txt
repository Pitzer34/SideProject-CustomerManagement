ver1.0
1. 使用MVP架構: View - IView - Presenter - IModel - Model
2. 建立基礎MVP架構
	2-1. CustomerView
	2-2. ICustomerView
	2-3. CustomerPresenter
	2-4. ICustomerRepository
	2-5. CustomerRepository
	2-6. CustomerModel
3. 建立Database: CustomerDb
4. 加入參考, 建立interface之間的連接
5. 設計CustomerView的Winform介面

ver2.0
1. 建立連線字串
2. CustomerView
	2-1. 建立事件
	2-2. 在click事件中進行委派觸發事件
	2-3. 修改屬性{get set}, 使觸發事件可以接收到值
3. CustomerPresenter
	3-1. 註冊事件
	3-2. 撰寫事件內容:load(), search()
4. CustomerRepository
	3-1. 撰寫getAll(), getByValue()

ver3.0
1. 階段功能測試與debug

ver4.0
1. CustomerPresenter
	1-1. 補齊剩餘事件內容:create(), edit(), delete(), save(), cancel()
2. CustomerRepository
	2-1. 補齊create(), edit(), delete()

ver5.0
1. 階段功能測試與debug
2. 新增Infrastuctures/Vaildation

ver6.0
1. 新增MainView與相關內容
2. 階段功能測試與debug
