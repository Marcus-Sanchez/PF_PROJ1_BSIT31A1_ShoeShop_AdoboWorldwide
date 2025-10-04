# 🚀 AdoboWorldwide Shoe Shop - Inventory Management System

![AdoboWorldwide Logo](https://img.shields.io/badge/AdoboWorldwide-Shoe%20Shop-blue?style=for-the-badge&logo=nike)

## 🎯 **PROJECT OVERVIEW**

**AdoboWorldwide Shoe Shop** is a modern, comprehensive **Shoe Inventory Management System** built with ASP.NET Core MVC using a **3-layer architecture**. This professional admin portal manages all shoe inventory operations including stock tracking, purchase orders, and inventory management with a beautiful, responsive user interface.

### **What We've Built:**
A **premium shoe inventory management system** featuring:
- 📦 **Advanced Inventory Management**: Intelligent shoe tracking, stock management, color variations
- 📝 **Smart Purchase Orders**: Streamlined ordering system with supplier management
- 📤 **Professional Pull-Outs**: Comprehensive inventory removal tracking with approval workflows
- 📈 **Dynamic Reports**: Real-time dashboard, automated low stock alerts, comprehensive analytics
- 🔐 **Secure Authentication**: Role-based access control (Admin, Manager, Staff)
- 📱 **Modern Responsive Design**: Professional AdoboWorldwide-branded interface
- 🎯 **Clean MVC Architecture**: Well-structured server-side rendering with Razor views

---

## 📋 **PROJECT REQUIREMENTS**

### **Core Features to Implement:**

#### 📦 **Inventory Management**
1. **Dashboard**: Overview of total inventory, low stock alerts, recent transactions
2. **Shoe Management**: Add, edit, delete shoes with color variations
3. **Stock Tracking**: Monitor current stock levels for each shoe/color combination
4. **Inventory Adjustments**: Manual stock adjustments with reason codes

#### 📝 **Purchase Orders & Restocking**
1. **Create Purchase Orders**: Order new inventory from suppliers
2. **Receive Orders**: Process incoming shipments and update stock levels
3. **Supplier Management**: Maintain supplier contact information
4. **Order History**: Track all purchase orders and their status (Pending, Received, Cancelled)

#### 📤 **Pull-Outs & Stock Removal**
1. **Pull-Out Requests**: Remove items from inventory with proper documentation
2. **Reason Codes**: Track why items are removed:
   - Damaged goods
   - Customer returns
   - Promotional items
   - Quality control issues
   - Theft/loss
3. **Approval Workflow**: Require manager approval for large pull-outs
4. **Pull-Out History**: Complete audit trail of all inventory removals

#### 🔧 **Technical Requirements**
1. **Database**: Store shoes, suppliers, orders, pull-outs with proper relationships
2. **Authentication**: ASP.NET Core Identity with Admin/Manager/Staff roles
3. **Validation**: Proper input validation and error handling
4. **Responsive UI**: Bootstrap 5 for professional admin interface
5. **MVC Architecture**: Controllers use Services directly (no API layer)

---

## 👥 **TEAM STRUCTURE & ROLES**

### **Form Groups of 4 Students**

| Student | Layer Assignment | Responsibilities | Branch Name |
|---------|-----------------|------------------|-------------|
| **Student A** | **Repository Layer** | Database, entities, data access | `dev-[firstname-lastname]` |
| **Student B** | **Service Layer** | Business logic, DTOs, validation | `dev-[firstname-lastname]` |
| **Student C** | **Web MVC Layer (UI/Design)** | Views, styling, user experience | `dev-[firstname-lastname]` |
| **Student D** | **Web MVC Layer (Controllers)** | Controllers, integration, workflows | `dev-[firstname-lastname]` |

### **Repository Setup:**
- **Repository Name**: `PF_PROJ1_BSIT_32xx_ShoeShop` (Example: `PF_PROJ1_BSIT_3201_ShoeShop`)
- **Total Branches**: 5 (1 protected main + 4 developer branches)
- **MS Teams Submission**: All 4 members submit the **SAME repository URL**

---

## 📂 **DATABASE SCHEMA REQUIREMENTS**

### **Required Tables/Entities:**

#### 1. **Shoes Table**
```sql
- Id (Primary Key)
- Name (Nike Air Max, Adidas Ultra Boost, etc.)
- Brand (Nike, Adidas, Puma, etc.)
- Cost (Decimal) - Purchase cost from supplier
- Price (Decimal) - Selling price
- Description (Text)
- ImageUrl (String, optional)
- IsActive (Boolean)
- CreatedDate (DateTime)
```

#### 2. **ShoeColorVariations Table**
```sql
- Id (Primary Key)
- ShoeId (Foreign Key to Shoes)
- ColorName (Red, Blue, White, etc.)
- HexCode (#FF0000, #0000FF, etc.)
- StockQuantity (Integer) - Current stock level
- ReorderLevel (Integer) - When to reorder (default: 5)
- IsActive (Boolean)
```

#### 3. **Suppliers Table**
```sql
- Id (Primary Key)
- Name (String) - Supplier company name
- ContactEmail (String)
- ContactPhone (String)
- Address (Text)
- IsActive (Boolean)
```

#### 4. **PurchaseOrders Table**
```sql
- Id (Primary Key)
- OrderNumber (String) - Unique order identifier
- SupplierId (Foreign Key to Suppliers)
- OrderDate (DateTime)
- ExpectedDate (DateTime) - Expected delivery date
- Status (Enum: Pending, Confirmed, Shipped, Received, Cancelled)
- TotalAmount (Decimal)
```

#### 5. **PurchaseOrderItems Table**
```sql
- Id (Primary Key)
- PurchaseOrderId (Foreign Key to PurchaseOrders)
- ShoeColorVariationId (Foreign Key to ShoeColorVariations)
- QuantityOrdered (Integer)
- QuantityReceived (Integer)
- UnitCost (Decimal) - Cost per unit
```

#### 6. **StockPullOuts Table**
```sql
- Id (Primary Key)
- ShoeColorVariationId (Foreign Key to ShoeColorVariations)
- Quantity (Integer) - Amount being removed
- Reason (String) - Damaged, Returned, Promotional, etc.
- ReasonDetails (Text, optional) - Additional explanation
- RequestedBy (String) - Who requested the pull-out
- ApprovedBy (String, optional) - Manager who approved
- PullOutDate (DateTime)
- Status (Enum: Pending, Approved, Completed, Rejected)
```

#### 7. **Users Table** (ASP.NET Core Identity)
```sql
- Standard Identity fields (Id, UserName, Email, etc.)
- FirstName (String)
- LastName (String)
- Role (Admin, Manager, Staff)
```

---

## 🔨 **DEVELOPMENT ASSIGNMENTS BY LAYER**

### 🗄️ **Student A: Repository Layer**
**Branch**: `dev-[your-firstname-lastname]`

#### **Your Tasks:**
1. **Create Entity Models** with proper EF Core annotations:
   - `Shoe.cs` - Main shoe entity with cost and price
   - `ShoeColorVariation.cs` - Color variations with stock tracking
   - `Supplier.cs` - Supplier information
   - `PurchaseOrder.cs` & `PurchaseOrderItem.cs` - Order management
   - `StockPullOut.cs` - Inventory removal tracking
   
2. **Setup DbContext**:
   - `ShoeShopDbContext.cs` with all DbSets
   - Configure relationships using Fluent API
   - Connection strings for SQLite (development) and SQL Server (production)

3. **Database Migrations**:
   - Create initial migration with all tables
   - Seed sample data (at least 15 shoes, 3 suppliers, sample orders)

4. **Console Testing Application**:
   - Create `ShoeShop.Repository.Console` project
   - Test all CRUD operations
   - Test complex queries (low stock, pending orders)
   - Test relationships and data integrity

#### **Deliverables:**
- [ ] Complete entity models with EF Core annotations (NOT validation annotations)
- [ ] DbContext with proper configuration and relationships
- [ ] Migration scripts with comprehensive seed data
- [ ] Console app demonstrating all database operations
- [ ] Documentation of database schema and relationships

---

### ⚙️ **Student B: Service Layer**
**Branch**: `dev-[your-firstname-lastname]`

#### **Your Tasks:**
1. **Create DTOs** with validation annotations (NOT EF Core annotations):
   - `CreateShoeDto.cs` - For creating new shoes
   - `ShoeDto.cs` - For displaying shoe data
   - `CreatePurchaseOrderDto.cs` - For creating orders
   - `PurchaseOrderDto.cs` - For displaying orders
   - `CreatePullOutDto.cs` - For pull-out requests
   - `PullOutRequestDto.cs` - For displaying pull-outs
   - `InventoryReportDto.cs` - For dashboard reports

2. **Implement Service Interfaces**:
   - `IInventoryService.cs` - Core inventory operations
   - `IPurchaseOrderService.cs` - Order management
   - `IPullOutService.cs` - Stock removal operations
   - `IReportService.cs` - Dashboard and reporting

3. **Business Logic Implementation**:
   - `InventoryService.cs` - Stock management, low stock alerts
   - `PurchaseOrderService.cs` - Order creation, receiving workflow
   - `PullOutService.cs` - Pull-out approval workflow
   - `ReportService.cs` - Inventory analytics and reporting
   - Validation rules (stock levels, order limits, approval thresholds)
   - Business calculations (inventory value, reorder points)

4. **Console Testing Application**:
   - Create `ShoeShop.Services.Console` project
   - Test all business logic and workflows
   - Test validation scenarios
   - Test exception handling

#### **Deliverables:**
- [ ] DTOs with validation annotations (for input validation)
- [ ] Service interfaces and complete implementations
- [ ] Business logic with inventory rules and workflows
- [ ] Console app demonstrating all business operations
- [ ] Documentation of business rules and validation logic

---

### 🎨 **Student C: Web MVC Layer (UI/Design)**
**Branch**: `dev-[your-firstname-lastname]`

#### **Your Tasks:**
1. **Razor Views & Templates**:
   - Create all Razor view templates (.cshtml files)
   - Design consistent layout and navigation for admin interface
   - Create reusable partial views and components
   - Design forms for all inventory operations

2. **Professional Admin Interface Design**:
   - Dashboard with inventory statistics and charts
   - Responsive design with Bootstrap 5
   - Professional admin panel styling and theme
   - Data tables with sorting, filtering, and pagination
   - Modal dialogs for quick actions (stock adjustments, approvals)
   - Form validation styling and error displays

3. **User Experience Design**:
   - Intuitive navigation for inventory operations
   - Consistent styling across all pages
   - Mobile-responsive admin interface
   - Loading states and progress indicators
   - Toast notifications for user feedback
   - Professional color scheme and typography

4. **Frontend Technologies**:
   - Bootstrap 5 for responsive design
   - jQuery for client-side interactions
   - Chart.js for inventory analytics and dashboards
   - DataTables for advanced table functionality
   - Font Awesome for professional icons

#### **Deliverables:**
- [ ] Complete set of professional Razor views
- [ ] Responsive admin interface with Bootstrap 5
- [ ] Interactive dashboard with charts and statistics
- [ ] Professional styling and consistent admin theme
- [ ] Client-side validation and user feedback systems
- [ ] Mobile-responsive design for all screens

---

### 🔧 **Student D: Web MVC Layer (Controllers/Integration)**
**Branch**: `dev-[your-firstname-lastname]`

#### **Your Tasks:**
1. **MVC Controllers** for all inventory operations:
   - `DashboardController.cs` - Main dashboard with statistics
   - `InventoryController.cs` - Shoe and stock management
   - `PurchaseOrderController.cs` - Complete order workflow
   - `PullOutController.cs` - Stock removal operations
   - `ReportsController.cs` - Inventory reports and analytics
   - `AccountController.cs` - Authentication and user management

2. **Business Flow Implementation**:
   - Complete inventory management workflow (add, edit, adjust stock)
   - Purchase order process (create, confirm, receive, track)
   - Pull-out approval workflow with manager authorization
   - Stock level monitoring and automated alerts
   - Report generation with filtering and export options

3. **Integration & Data Flow**:
   - Reference Service Layer directly in controllers
   - Handle DTOs and model binding properly
   - Implement comprehensive error handling
   - Manage user sessions and authentication state
   - Handle file uploads (shoe images)
   - AJAX operations for real-time updates

4. **Security & Authorization**:
   - Role-based authorization `[Authorize(Roles = "Admin,Manager")]`
   - Secure form handling with anti-forgery tokens
   - Input validation and sanitization
   - Audit logging for sensitive inventory operations

#### **Deliverables:**
- [ ] Complete set of MVC controllers for all operations
- [ ] Full inventory management workflow implementation
- [ ] Complete purchase order system with approval workflow
- [ ] Pull-out request system with manager approval
- [ ] Authentication and role-based authorization
- [ ] Comprehensive error handling and logging
- [ ] Complete integration with Service Layer

---

## 🚀 **STEP-BY-STEP IMPLEMENTATION GUIDE**

### **Week 1: Setup & Individual Development**

#### **Day 1-2: Project Setup**
1. **Repository Manager** (Student A) creates repository: `PF_PROJ1_BSIT_32xx_ShoeShop`
2. All 4 team members clone the repository
3. Each student creates their branch: `git checkout -b dev-[firstname-lastname]`
4. Set up branch protection rules for main/master

#### **Day 3-7: Layer Implementation**
- **Student A**: Create entities, DbContext, migrations, seed data
- **Student B**: Create DTOs, service interfaces, business logic
- **Student C**: Start designing Razor views and admin interface (use mock data)
- **Student D**: Start MVC controllers and integration logic (use mock data)

### **Week 2: Testing & Refinement**

#### **Individual Testing**
- **Students A & B**: Complete console applications for testing
- **Students C & D**: Test MVC applications with mock services
- All students create first Pull Request with initial implementation

### **Week 3: Integration**

#### **Layer Integration**
1. **Repository Manager** merges Repository layer PR
2. **Student B** updates branch, references Repository, creates integration PR
3. **Students C & D** update branches, reference Service layer, create integration PRs
4. Test complete inventory management application flow

### **Week 4: Final Testing & Presentation**

#### **Final Integration & Testing**
- Complete end-to-end testing of all inventory operations
- Bug fixes and performance optimizations
- Documentation updates and user guides
- Prepare comprehensive presentation

---

## 📋 **SUBMISSION REQUIREMENTS**

### **MS Teams Submission**
**All 4 team members submit the SAME repository URL**: `PF_PROJ1_BSIT_32xx_ShoeShop`

### **Individual Requirements**
Each student must have:
- [ ] Complete implementation of assigned layer
- [ ] At least **10 meaningful commits** on their branch
- [ ] At least **2 Pull Requests** to main/master
- [ ] **Console app** (Repository & Service) or **MVC Web application** (UI & Controllers)
- [ ] Documentation in `docs/[layer]-docs.md`

### **Team Requirements**
- [ ] **Working inventory management application** with all layers integrated
- [ ] **10-minute presentation** demonstrating all features
- [ ] **GitHub repository** with complete commit history
- [ ] **No zip files** - everything must be in Git branches

---

## 🎯 **GRADING CRITERIA (100 Points)**

### **Individual Work (70 points)**
- **Functionality** (30 points): Layer works correctly with all required features
- **Code Quality** (20 points): Clean, readable, well-structured code
- **Testing** (10 points): Console apps or web testing demonstrate functionality
- **Git Usage** (10 points): Regular commits, meaningful messages, proper branching

### **Team Collaboration (20 points)**
- **Integration** (10 points): Layers work together seamlessly
- **Pull Requests** (10 points): Quality PRs with reviews and discussions

### **Presentation (10 points)**
- **Demo** (5 points): Successfully demonstrate complete inventory operations
- **Explanation** (5 points): Clearly explain your layer and team integration

---

## ⚠️ **CRITICAL RULES**

1. **🚫 NO ZIPPED FILES ALLOWED** - All work must be in Git branches
2. **🔒 Protected Main Branch** - Only Repository Manager can merge
3. **📝 Pull Requests Required** - No direct pushes to main
4. **🌿 Work on Your Branch Only** - `dev-[firstname-lastname]`
5. **👥 Code Reviews Required** - Cannot approve your own PRs
6. **📅 Weekly Check-ins** - Show progress every week
7. **📊 Annotations Matter** - EF Core annotations for entities, validation annotations for DTOs

---

## 💡 **SUCCESS TIPS**

1. **Start with the lesson plans** - Study your assigned layer thoroughly
2. **Understand the difference** - EF Core annotations vs validation annotations
3. **Communicate through GitHub** - Use Issues, PR comments, and Discussions
4. **Test frequently** - Make sure your layer works before integration
5. **Ask for help early** - Don't struggle alone
6. **Document everything** - Good docs help your team and grading
7. **Review teammates' code** - Learn from each other
8. **Focus on inventory operations** - This is not a customer shopping site

---

## 📚 **RESOURCES**

- **Repository Layer**: `REPOSITORY_LAYER_LESSON.md`
- **Service Layer**: `SERVICE_LAYER_LESSON.md` 
- **Web Layer**: `WEB_LAYER_LESSON.md`
- **GitHub Guides**: [GitHub Flow](https://guides.github.com/introduction/flow/)
- **ASP.NET Core Docs**: [Microsoft Documentation](https://docs.microsoft.com/en-us/aspnet/core/)

---

**Good luck building your Shoe Inventory Management System! Remember: Individual excellence + Team collaboration = Project success! 🎉📦**
