# ⚔️ Clash Royale Style Game - Unity

> 🚧 **Currently in Development**

A scalable **Clash Royale–inspired real-time strategy card battler prototype** built in **Unity**, following **SOLID principles, clean architecture, state-driven AI, interface-driven systems, and ScriptableObject-based unit configuration**.

This project is designed as a **production-ready foundation** for building a polished **multiplayer-ready strategy card battler** with scalable gameplay systems, reusable unit architecture, abilities, spell support, and progression systems.

---

# 🎯 Project Vision

The goal of this project is to create a **modular, extensible, and production-scalable Clash Royale style architecture** supporting:

- ⚔️ Real-time troop battles
- 🏰 Tower defense gameplay
- 🎴 Deck-based troop deployment
- 🧠 Smart state-driven troop AI
- 🐉 Air and ground movement systems
- ✨ Ability-based units
- 💥 Spell cards
- 📈 Card level progression
- 🔥 Multiplayer-ready scalability

---

# 🎮 Current Features

## ⚔️ Gameplay Systems
- ✅ Unit spawning system
- ✅ Elixir-based card deployment
- ✅ Clash Royale style deck UI
- ✅ Card cycling after deployment
- ✅ Deck selection UI architecture
- ✅ Health and damage system
- ✅ Melee and ranged combat
- ✅ Projectile attack support
- ✅ Tower attack system
- ✅ Dynamic retargeting while moving
- ✅ Attack cooldown system using reusable timer
- ✅ Attack lock while attacking
- ✅ Unit death handling
- ✅ Tower-only unit logic *(Giant style)*
- ✅ Air / ground targeting separation
- ✅ Flying unit movement *(Dragon / Minions ready)*
- ✅ NavMesh + manual air movement hybrid system
- ✅ Unit pooling system
- ✅ Preview-based troop placement

---

## ✨ Unit Abilities System
Scalable **ability-driven troop extension system** added for special cards.

### Current architecture supports:
- ✅ `ICardAbility`
- ✅ `AbilityManager`
- ✅ Ability trigger through combat states
- ✅ Temporary invulnerability support
- ✅ Dash / charge abilities
- ✅ Custom future hero/champion logic

### Example supported cards
- ⚡ Bandit Dash
- 🐎 Prince Charge
- 💣 Death explosion
- 💚 Heal pulse
- ❄️ Freeze aura

---

## 💥 Spell Card System
A separate **card play architecture for spell cards**.

Supports:
- ✅ Rocket
- ✅ Fireball
- ✅ Poison
- ✅ Zap
- ✅ Rage
- ✅ Freeze

Spell cards are separated from troop state machine logic for clean scalability.

---

## 📈 Card Level Progression System
Added a **Clash Royale style level progression architecture**.

### Uses separate ScriptableObjects:
- ✅ `UnitData` → static immutable gameplay data
- ✅ `UnitLevelStats` → per-level damage & health
- ✅ `PlayerCardLevelDatabase` → player-owned card levels

### Supports:
- ✅ Level-based health scaling
- ✅ Level-based damage scaling
- ✅ Upgrade-ready balancing workflow
- ✅ Future chest / progression systems
- ✅ Designer-friendly stat tuning

---

# 🧠 AI State Machine

Each troop uses a **clean scalable state-driven AI controller**.

## Current States
- `IdleState`
- `MoveState`
- `AttackState`

## Current Behaviors
- Find nearest enemy
- Move toward target
- Retarget while moving
- Lock movement during attack
- Resume movement after target death
- Custom target logic support
- Tower prioritization support
- Ability execution support
- Dash/charge behavior support
- Air unit XZ-plane movement

This architecture easily supports units like:

- 🗡️ Knight
- 🏹 Archer
- 👹 Goblin
- 🎯 Dart Goblin
- 🪨 Giant
- 🐉 Baby Dragon
- ⚡ Bandit
- 🐎 Prince

---

# 📦 Data Driven Design

All troops and cards are configured using **ScriptableObjects**.

## `UnitData` contains static gameplay:
- Unit ID
- Unit prefab
- Preview prefab
- Card sprite
- Move speed
- Attack range
- Detection radius
- Attack cooldown
- Elixir cost
- Attack type
- Movement type
- Target preference
- Ability support
- Spell card link
- Tower priority support

## `UnitLevelStats`
- Health per level
- Damage per level

This allows:

- ⚡ Quick balancing
- 🎴 Easy card additions
- 🔧 No code changes for stats
- 📈 Easy progression scaling
- 🚀 Designer-friendly workflow

---

# 🏗️ Architecture

Built using **SOLID principles + clean modular architecture + interface-driven systems**.

## 🔧 Core Systems
- `HealthManager`
- `AttackingSystem`
- `AbilityManager`
- `TargetingSystem`
- `TowerSystem`
- `UnitSpawnSystem`
- `UnitDeckUI`
- `DeckSelectionUI`
- `UnitCardView`
- `UnitStateController`
- `Timer`
- `EventManager`
- `PlayerCardLevelDatabase`
- `UnitPoolManager`

---

# 🧩 Interfaces
The combat architecture is highly decoupled using interfaces.

- `IUnit`
- `IDamageable`
- `ITargetingStrategy`
- `IAttack`
- `ICardAbility`
- `ICardPlayable`

This makes the game highly extensible for:
- troops
- towers
- spells
- bosses
- champions
- status effects

---

# 🧩 Design Patterns Used

This project uses multiple scalable software patterns:

- ✅ **State Pattern** → troop AI
- ✅ **Strategy Pattern** → targeting & movement
- ✅ **Observer/Event Pattern** → gameplay events
- ✅ **ScriptableObject Data Pattern** → unit configs
- ✅ **Object Pool Pattern** → units & projectiles
- ✅ **Ability Composition Pattern**
- ✅ **Interface-driven architecture**
- ✅ **Dependency Injection style references**

---

# 🚀 Future Roadmap

Planned features:

- [ ] Multiplayer support
- [ ] Better card animations
- [ ] Champion units
- [ ] Hero active abilities
- [ ] Building cards
- [ ] Spell VFX system
- [ ] Crown tower victory logic
- [ ] Chest / progression system
- [ ] Match timer
- [ ] Better VFX / SFX
- [ ] Mobile optimization
- [ ] Event-driven UI refresh
- [ ] Evolution cards
- [ ] Ranked ladder
- [ ] Replay system
