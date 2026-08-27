# Database Systems

An end-to-end database design and implementation repository developed for the **Database Systems** course. This repository spans the complete relational database lifecycle: conceptual modeling with Entity-Relationship (ER/EER) diagrams, logical schema mapping and normalization, physical Data Definition Language (DDL) enforcement with integrity constraints, complex Data Manipulation Language (DML) queries, and advanced procedural programming (Stored Procedures, User-Defined Functions, Event Triggers, and Simple & Materialized Views).

---

## 🛠 Tech Stack & Tools

- **Query Languages & Dialects:** ANSI SQL, PostgreSQL / PL/pgSQL, T-SQL, MySQL
- **RDBMS Platforms:** PostgreSQL, MySQL, Microsoft SQL Server
- **Modeling & Client Utilities:** EdrawMax (ER/EER Modeling), `psql` CLI, pgAdmin, DBeaver
- **Core Database Paradigms:** Conceptual Modeling (ER/EER), Relational Algebra & Calculus, Schema Normalization (1NF–BCNF), Constraints & Indexing, Procedural Database Programming

---

## 📁 Repository Structure

### 📚 Coursework & Theoretical Foundations
| Directory | Focus & Core Concepts | Key Artifacts |
| :--- | :--- | :--- |
| `HW5/` | Relational algebra query design, relational calculus expressions, and query optimization | Query scripts, problem sets |

### 🗄 Project Lifecycle (Phases 2 – 5)
| Phase | Stage | Focus & Deliverables | Primary Artifacts |
| :--- | :--- | :--- | :--- |
| `Project_P2/` | **Conceptual Design** | Business requirements analysis, entity-relationship identification, and high-level ER/EER diagrams | ER/EER Diagrams (`.eddx`, `.png`) |
| `Project_P3/` | **Logical Design** | ER-to-Relational schema transformation, cardinality mapping, foreign key definitions, and normalization | Relational Schema Mapping |
| `Project_P4/` | **Physical Implementation** | DDL schema creation, primary/foreign key constraints, comprehensive data insertion, and CRUD queries | `table.sql`, `constraints.sql`, `Inserts .sql`, `Selects.sql` |
| `Project_P5/` | **Procedural Logic & Views** | Advanced database logic: Stored Procedures, UDFs, automated validation Triggers, and Materialized Views | `function.sql`, `procedures.sql`, `triggers.sql`, `views(simple and matreialized).sql` |

---

## 🚀 Getting Started

### Prerequisites
- An active RDBMS instance (e.g., [PostgreSQL](https://www.postgresql.org/), [MySQL](https://www.mysql.com/), or [SQL Server](https://www.microsoft.com/sql-server/))
- Command-line interface (`psql`, `mysql`) or GUI client ([DBeaver](https://dbeaver.io/), [pgAdmin](https://www.pgadmin.org/))

---

## 🧪 Deployment & Execution Guide

### 1. Phase 4: Core Schema Instantiation & Data Population
Execute the SQL deployment scripts in sequence against your target database using `psql`:

```bash
cd "Project_P4/sql faz4"

# 1. Instantiate base tables (DDL)
psql -U <username> -d <database_name> -f "table.sql"

# 2. Apply foreign keys and integrity constraints
psql -U <username> -d <database_name> -f "constraints.sql"

# 3. Populate tables with initial dataset (DML)
psql -U <username> -d <database_name> -f "Inserts .sql"

# 4. Execute test validation and analytical queries
psql -U <username> -d <database_name> -f "Selects.sql"
```

---

### 2. Phase 5: Procedural Programming, Triggers & Views
Deploy the advanced database features and automation routines:

```bash
cd "Project_P5/Faz5/Faz5"

# 1. Create standard and Materialized Views
psql -U <username> -d <database_name> -f "views(simple and matreialized).sql"

# 2. Deploy User-Defined Functions (UDFs)
psql -U <username> -d <database_name> -f "function.sql"

# 3. Deploy Stored Procedures
psql -U <username> -d <database_name> -f "procedures.sql"

# 4. Attach event-driven validation Triggers
psql -U <username> -d <database_name> -f "triggers.sql"

# 5. Run procedural validation and reporting queries
psql -U <username> -d <database_name> -f "Selects.sql"
```

---

## 📜 Academic Disclaimer
The source code and database artifacts in this repository are maintained for portfolio, archival, and educational reference purposes.