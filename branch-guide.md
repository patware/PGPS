# Branching Guide

This repository follows a simple, policy-driven branching strategy designed for **clarity, control, and safe collaboration**.

---

## 🌿 Branch Model

### `main`

* Production-ready code only
* Protected by branch policies
* No direct pushes allowed
* Updated via Pull Requests from any other branch

---

### Working branches

All work must be done in short-lived branches created from `main`.

These branches represent:

* features
* bug fixes
* experiments
* tests

---

## 🔄 Workflow

```text
feature/* → main
```

1. Create a branch from `main`
2. Implement your changes
3. Open a Pull Request into `main`

---

## 🏷️ Naming Convention

Branches must follow this format:

```text
{category}/{description-in-kebab-case}
```

### Categories

Use one of the following:

* `feature` → new functionality
* `bugfix` → non-critical defect fix
* `hotfix` → urgent fix (typically production-related)
* `test` → experiments, demos, or validation work

---

### Description (kebab-case)

* lowercase only
* words separated by hyphens (`-`)

Example:

```text
feature/add-user-authentication
bugfix/fix-null-reference-error
hotfix/resolve-login-timeout
test/pipeline-validation-scenario
```

Reference: kebab case

---

## 🚫 What is NOT allowed

* Direct commits to `main`
* Long-lived feature branches
* Branch names without a category
* Use of uppercase, spaces, or special characters

---

## 🎯 Rationale

This strategy ensures:

* Stable and releasable state in `main`
* Clear traceability of work
* Consistent branch naming across teams

---

## 🧪 Training Notes

This repository is used for demonstration purposes. Try the following:

* Create a branch that violates naming conventions
* Attempt a direct push to `main`
* Open a Pull Request without required reviewers

Observe how policies enforce the workflow.
