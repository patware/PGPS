# Contributing Guide

Thank you for contributing to this repository.

This project stems from the need for generating POCO with a patterned property getters setters.

---

## 🎯 Principles

* All changes go through **Pull Requests (PRs)**
* No direct commits to protected branches (`main`)
* Work must be **traceable, reviewable, and validated**

---

## 🌿 Branching

Follow the conventions defined in [branch-guide.md](branch-guide.md).

### Summary

* Branch from `main`
* Use naming format:

```text
{category}/{description-in-kebab-case}
```

Example:

```text
feature/add-logging
bugfix/fix-null-check
```

---

## 🔄 Contribution Workflow

```text
1. Create branch from main
2. Commit changes
3. Push branch
4. Open PR → main
5. Address review feedback
6. Merge after validation
```

---

## 💻 Development Guidelines

### General

* Keep changes **small and focused**
* Prefer **readability over cleverness**
* Avoid unrelated refactoring in the same PR

---

### .NET

* Build must succeed (`dotnet build`)
* Follow rules defined in:

  * `.editorconfig`
  * `Directory.Build.props`
* Run:

```powershell
dotnet format
```

---

## 🧪 Testing

* Add or update tests when modifying behavior
* Ensure all tests pass before submitting a PR

```powershell
dotnet test
```

---

## 📦 Commit Guidelines

* Use clear, descriptive commit messages
* Prefer:

```text
<type>: <short description>
```

Examples:

```text
feat: add input validation
fix: handle null reference in service
```

---

## 🔍 Pull Request Expectations

A PR must:

* Target the `main` branch
* Be linked to a clear purpose (feature, fix, test)
* Pass all pipeline checks
* Be reviewed and approved

---

### PR Checklist

* [ ] Branch name follows convention
* [ ] Code builds successfully
* [ ] Tests pass
* [ ] Linting/formatting checks pass
* [ ] No secrets or sensitive data included
* [ ] Changes are scoped and understandable

---

## 🚫 What is NOT allowed

* Direct commits to `main`
* Large, unfocused PRs
* Skipping code review
* Ignoring pipeline failures

---

## ❓ Questions

Refer to:

* [README.md](README.md)
* [SUPPORT.md](SUPPORT.md)

Or contact the repository maintainers.
