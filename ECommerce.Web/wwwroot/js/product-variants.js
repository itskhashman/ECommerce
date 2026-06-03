let variantIndex = 0;
let productMode = "simple";


function getSimpleVariantCardTemplate(index, id = 0, nameEn = "", nameAr = "") {
    return `
            <div class="card shadow-sm mb-4 border-secondary simple-variant-card" id="simple_card_${index}">
                <div class="card-header bg-primary text-white d-flex justify-content-between align-items-center py-2">
                    <h6 class="mb-0 fw-bold"><i class="bi bi-tags me-2"></i>Variant Type</h6>
                    <button type="button" class="btn btn-sm btn-light text-danger py-0 px-2" onclick="window.ProductVariantsManager.removeSimpleVariant(${index})">
                        <i class="bi bi-trash"></i> Remove
                    </button>
                </div>
                <div class="card-body p-3 bg-white">
                    <input type="hidden" data-simple-type="Id" value="${id}" />
                    <div class="row align-items-center mb-3">
                        <div class="col-md-6">
                            <label class="form-label small fw-bold text-secondary">Variant Type Name (EN)</label>
                            <input type="text" data-simple-type="NameEn" class="form-control form-control-sm" value="${nameEn}" placeholder="e.g. Color" required />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label small fw-bold text-secondary text-end d-block">اسم نوع المتغير (عربي)</label>
                            <input type="text" data-simple-type="NameAr" class="form-control form-control-sm text-end" value="${nameAr}" placeholder="مثال: اللون" required dir="rtl" />
                        </div>
                    </div>

                    <div class="border rounded p-3 bg-light">
                        <span class="small fw-bold text-dark d-block mb-3">Options, Prices & Stock</span>
                        <div class="simple-options-container mb-2" id="simple_options_container_${index}"></div>
                        <div class="input-group input-group-sm mt-2" style="max-width: 650px;">
                            <input type="text" class="form-control" id="simple_input_en_${index}" placeholder="Option (EN) e.g Red" />
                            <input type="text" class="form-control text-end" id="simple_input_ar_${index}" placeholder="الخيار (عربي) مثال: أحمر" dir="rtl" />
                            <input type="number" class="form-control" id="simple_input_price_${index}" placeholder="Price" min="0" step="0.01" value="0.00" style="max-width: 85px;" />
                            <input type="number" class="form-control" id="simple_input_stock_${index}" placeholder="Stock" min="0" value="0" style="max-width: 75px;" />
                            <button class="btn btn-secondary" type="button" onclick="window.ProductVariantsManager.addSimpleOption(${index})">Add Option</button>
                        </div>
                    </div>
                </div>
            </div>`;
}

function getSimpleOptionRowTemplate(valueEn, valueAr, price = 0, stock = 0, id = 0) {
    return `
            <div class="row g-2 align-items-center mb-2 bg-white p-2 rounded simple-option-row border mx-0">
                <div class="col-sm-3"><input type="text" data-simple-opt-type="NameEn" class="form-control form-control-sm" value="${valueEn}" required /></div>
                <div class="col-sm-3"><input type="text" data-simple-opt-type="NameAr" class="form-control form-control-sm text-end" value="${valueAr}" required dir="rtl" /></div>
                <div class="col-sm-3 col-5">
                    <div class="input-group input-group-sm">
                        <span class="input-group-text">JOD</span>
                        <input type="number" data-simple-opt-type="Price" class="form-control" value="${price}" min="0" step="0.01" required />
                    </div>
                </div>
                <div class="col-sm-2 col-5"><input type="number" data-simple-opt-type="Stock" class="form-control form-control-sm" value="${stock}" min="0" required /></div>
                <div class="col-sm-1 col-2 text-end">
                    <input type="hidden" data-simple-opt-type="Id" value="${id}" />
                    <button type="button" class="btn btn-sm text-danger p-0" onclick="this.closest('.simple-option-row').remove(); window.ProductVariantsManager.reindex();">
                        <i class="bi bi-trash"></i>
                    </button>
                </div>
            </div>`;
}


function getNestedVariantCardTemplate(index, id = 0, nameEn = "", nameAr = "") {
    return `
            <div class="card shadow-sm mb-4 border-primary variant-item-card" id="variant_card_${index}">
                <div class="card-header bg-primary text-white d-flex justify-content-between align-items-center py-2">
                    <h6 class="mb-0 fw-bold"><i class="bi bi-layer-forward me-2"></i>Main Variant</h6>
                    <button type="button" class="btn btn-sm btn-light text-danger py-0 px-2" onclick="window.ProductVariantsManager.removeVariant(${index})">
                        <i class="bi bi-trash"></i> Remove
                    </button>
                </div>

                <div class="card-body p-3">
                    <input type="hidden" data-name-type="Id" value="${id}" />
                    <div class="row align-items-center mb-3">
                        <div class="col-md-6">
                            <label class="form-label small fw-bold text-secondary">Variant Type Name (EN)</label>
                            <input type="text" data-name-type="NameEn" class="form-control form-control-sm" value="${nameEn}" placeholder="e.g. Storage" required />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label small fw-bold text-secondary text-end d-block">Variant Type Name (AR)</label>
                            <input type="text" data-name-type="NameAr" class="form-control form-control-sm text-end" value="${nameAr}" placeholder="مثال: المساحة التخزينية" required dir="rtl" />
                        </div>
                    </div>

                    <div class="border rounded p-3 bg-light">
                        <span class="small fw-bold text-dark d-block mb-2">Add Main Options</span>
                        <div class="main-options-container" id="main_options_container_${index}"></div>
                        <div class="input-group input-group-sm mt-2" style="max-width: 500px;">
                            <input type="text" class="form-control" id="main_input_en_${index}" placeholder="Value (EN) e.g. 256GB" />
                            <input type="text" class="form-control text-end" id="main_input_ar_${index}" placeholder="Value (AR)" dir="rtl" />
                            <button class="btn btn-primary" type="button" onclick="window.ProductVariantsManager.addMainOption(${index})">Add Main Option</button>
                        </div>
                    </div>
                </div>
            </div>`;
}

function getMainOptionTemplate(variantCardId, optionIdx, valueEn, valueAr, id = 0) {
    return `
            <div class="card border-secondary mb-3 shadow-sm bg-white main-option-group" id="main_opt_${variantCardId}_${optionIdx}">
                <div class="card-body p-3">
                    <div class="d-flex justify-content-between align-items-center border-bottom pb-2 mb-3">
                        <div><span class="badge bg-secondary me-2">Main Option:</span><strong class="text-dark">${valueEn} | ${valueAr}</strong></div>
                        <button type="button" class="btn btn-xs btn-outline-danger py-0 px-2 small" onclick="this.closest('.main-option-group').remove(); window.ProductVariantsManager.reindex();"><i class="bi bi-x"></i> Delete Option</button>
                    </div>
                    <input type="hidden" data-opt-type="Id" value="${id}" />
                    <input type="text" data-opt-type="NameEn" class="d-none" value="${valueEn}" />
                    <input type="text" data-opt-type="NameAr" class="d-none" value="${valueAr}" />

                    <div class="ps-3 border-start border-3 border-info bg-light p-2 rounded">
                        <span class="small fw-bold text-info d-block mb-2">Add Sub-Variants (Under ${valueEn})</span>
                        <div class="sub-variants-container mb-2" id="sub_variants_container_${variantCardId}_${optionIdx}"></div>
                        <div class="input-group input-group-sm mt-2" style="max-width: 500px;">
                            <input type="text" class="form-control" id="sub_var_input_en_${variantCardId}_${optionIdx}" placeholder="Sub-Variant Name (EN) e.g. Color" />
                            <input type="text" class="form-control text-end" id="sub_var_input_ar_${variantCardId}_${optionIdx}" placeholder="Sub-Variant Name (AR)" dir="rtl" />
                            <button class="btn btn-info text-white" type="button" onclick="window.ProductVariantsManager.addSubVariant(${variantCardId}, ${optionIdx})">Add Sub-Variant</button>
                        </div>
                    </div>
                </div>
            </div>`;
}

function getSubVariantTemplate(variantCardId, optionIdx, subVarIdx, nameEn, nameAr, id = 0) {
    return `
            <div class="card border-info mb-3 shadow-sm bg-white sub-variant-group" id="sub_var_${variantCardId}_${optionIdx}_${subVarIdx}">
                <div class="card-body p-2">
                    <div class="d-flex justify-content-between align-items-center border-bottom pb-1 mb-2">
                        <div><span class="badge bg-info text-white me-2">Sub-Variant:</span><strong class="text-dark">${nameEn} | ${nameAr}</strong></div>
                        <button type="button" class="btn btn-xs btn-outline-danger py-0 px-1 small" style="font-size: 0.75rem;" onclick="this.closest('.sub-variant-group').remove(); window.ProductVariantsManager.reindex();"><i class="bi bi-trash"></i> Delete Sub-Variant</button>
                    </div>
                    <input type="hidden" data-subvar-type="Id" value="${id}" />
                    <input type="text" data-subvar-type="NameEn" class="d-none" value="${nameEn}" />
                    <input type="text" data-subvar-type="NameAr" class="d-none" value="${nameAr}" />

                    <div class="ps-3 border-start border-2 border-warning">
                        <label class="form-label small fw-bold text-warning d-block mb-2">Sub-Options, Price & Stock</label>
                        <div class="sub-options-container mb-2" id="sub_options_container_${variantCardId}_${optionIdx}_${subVarIdx}"></div>
                        <div class="input-group input-group-sm" style="max-width: 650px;">
                            <input type="text" class="form-control" id="sub_opt_input_en_${variantCardId}_${optionIdx}_${subVarIdx}" placeholder="Option (EN) e.g. Silver" />
                            <input type="text" class="form-control text-end" id="sub_opt_input_ar_${variantCardId}_${optionIdx}_${subVarIdx}" placeholder="Option (AR)" dir="rtl" />
                            <input type="number" class="form-control" id="sub_opt_input_price_${variantCardId}_${optionIdx}_${subVarIdx}" placeholder="Price" min="0" step="0.01" value="0.00" style="max-width: 85px;" />
                            <input type="number" class="form-control" id="sub_opt_input_stock_${variantCardId}_${optionIdx}_${subVarIdx}" placeholder="Stock" min="0" value="0" style="max-width: 75px;" />
                            <button class="btn btn-warning text-dark fw-bold" type="button" onclick="window.ProductVariantsManager.addSubOption(${variantCardId}, ${optionIdx}, ${subVarIdx})">Add Option</button>
                        </div>
                    </div>
                </div>
            </div>`;
}

function getSubOptionRowTemplate(valueEn, valueAr, price = 0, stock = 0, id = 0) {
    return `
            <div class="row g-2 align-items-center mb-2 bg-light p-2 rounded sub-option-row border mx-0">
                <div class="col-sm-3"><input type="text" data-sub-type="NameEn" class="form-control form-control-sm" value="${valueEn}" required /></div>
                <div class="col-sm-3"><input type="text" data-sub-type="NameAr" class="form-control form-control-sm text-end" value="${valueAr}" required dir="rtl" /></div>
                <div class="col-sm-3 col-5">
                    <div class="input-group input-group-sm">
                        <span class="input-group-text">JOD</span>
                        <input type="number" data-sub-type="Price" class="form-control" value="${price}" min="0" step="0.01" required />
                    </div>
                </div>
                <div class="col-sm-2 col-5"><input type="number" data-sub-type="Stock" class="form-control form-control-sm" value="${stock}" min="0" required /></div>
                <div class="col-sm-1 col-2 text-end">
                    <input type="hidden" data-sub-type="Id" value="${id}" />
                    <button type="button" class="btn btn-sm text-danger p-0" onclick="this.closest('.sub-option-row').remove(); window.ProductVariantsManager.reindex();">
                        <i class="bi bi-trash"></i>
                    </button>
                </div>
            </div>`;
}


function initWithData(variants, isNestedMode = false) {
    productMode = isNestedMode ? "nested" : "simple";
    const container = document.getElementById("variantsList");
    if (!container) return;

    container.innerHTML = "";
    variantIndex = 0;

    if (!variants || variants.length === 0) {
        attachFormSubmitListener();
        return;
    }

    try {
        variants.forEach((variant) => {
            const variantId = variant.id !== undefined ? variant.id : (variant.Id || 0);
            const variantNameEn = variant.nameEn || variant.NameEn || "";
            const variantNameAr = variant.nameAr || variant.NameAr || "";
            const variantOptions = variant.options || variant.Options || [];

            if (productMode === "simple") {
                container.insertAdjacentHTML('beforeend', getSimpleVariantCardTemplate(variantIndex, variantId, variantNameEn, variantNameAr));
                const optionsContainer = document.getElementById(`simple_options_container_${variantIndex}`);

                if (optionsContainer && variantOptions.length > 0) {
                    variantOptions.forEach(opt => {
                        const optId = opt.id !== undefined ? opt.id : (opt.Id || 0);
                        const optNameEn = opt.nameEn || opt.NameEn || "";
                        const optNameAr = opt.nameAr || opt.NameAr || "";
                        const optPrice = opt.price !== undefined ? opt.price : (opt.Price || 0);
                        const optStock = opt.stock !== undefined ? opt.stock : (opt.Stock || 0);

                        optionsContainer.insertAdjacentHTML('beforeend',
                            getSimpleOptionRowTemplate(optNameEn, optNameAr, optPrice, optStock, optId)
                        );
                    });
                }
            } else {
                container.insertAdjacentHTML('beforeend', getNestedVariantCardTemplate(variantIndex, variantId, variantNameEn, variantNameAr));
                const mainOptionsContainer = document.getElementById(`main_options_container_${variantIndex}`);

                if (mainOptionsContainer && variantOptions.length > 0) {
                    variantOptions.forEach((opt, oIdx) => {
                        const optId = opt.id !== undefined ? opt.id : (opt.Id || 0);
                        const optNameEn = opt.nameEn || opt.NameEn || "";
                        const optNameAr = opt.nameAr || opt.NameAr || "";
                        const subVariants = opt.subVariants || opt.SubVariants || [];

                        mainOptionsContainer.insertAdjacentHTML('beforeend',
                            getMainOptionTemplate(variantIndex, oIdx, optNameEn, optNameAr, optId)
                        );

                        if (subVariants.length > 0) {
                            const subVarContainer = document.getElementById(`sub_variants_container_${variantIndex}_${oIdx}`);

                            subVariants.forEach((sv, svIdx) => {
                                const svId = sv.id !== undefined ? sv.id : (sv.Id || 0);
                                const svNameEn = sv.nameEn || sv.NameEn || "";
                                const svNameAr = sv.nameAr || sv.NameAr || "";
                                const subOptions = sv.subOptions || sv.SubOptions || [];

                                subVarContainer.insertAdjacentHTML('beforeend',
                                    getSubVariantTemplate(variantIndex, oIdx, svIdx, svNameEn, svNameAr, svId)
                                );

                                if (subOptions.length > 0) {
                                    const subOptionsContainer = document.getElementById(`sub_options_container_${variantIndex}_${oIdx}_${svIdx}`);

                                    subOptions.forEach((subOpt) => {
                                        const subOptId = subOpt.id !== undefined ? subOpt.id : (subOpt.Id || 0);
                                        const subOptNameEn = subOpt.nameEn || subOpt.NameEn || "";
                                        const subOptNameAr = subOpt.nameAr || subOpt.NameAr || "";
                                        const subOptPrice = subOpt.price !== undefined ? subOpt.price : (subOpt.Price || 0);
                                        const subOptStock = subOpt.stock !== undefined ? subOpt.stock : (subOpt.Stock || 0);

                                        subOptionsContainer.insertAdjacentHTML('beforeend',
                                            getSubOptionRowTemplate(subOptNameEn, subOptNameAr, subOptPrice, subOptStock, subOptId)
                                        );
                                    });
                                }
                            });
                        }
                    });
                }
            }
            variantIndex++;
        });
    } catch (error) {
        console.error("An error occurred during template rendering loop:", error);
    }

    reindexFormAttributes();
    attachFormSubmitListener();
}

function addSimpleVariantCard() {
    const container = document.getElementById("variantsList");
    if (!container) return;
    container.insertAdjacentHTML('beforeend', getSimpleVariantCardTemplate(variantIndex));
    variantIndex++;
    reindexFormAttributes();
}

function addNestedVariantCard() {
    const container = document.getElementById("variantsList");
    if (!container) return;
    container.insertAdjacentHTML('beforeend', getNestedVariantCardTemplate(variantIndex));
    variantIndex++;
    reindexFormAttributes();
}

function addSimpleOption(idx) {
    const enIn = document.getElementById(`simple_input_en_${idx}`);
    const arIn = document.getElementById(`simple_input_ar_${idx}`);
    const prIn = document.getElementById(`simple_input_price_${idx}`);
    const stIn = document.getElementById(`simple_input_stock_${idx}`);
    const target = document.getElementById(`simple_options_container_${idx}`);

    if (!enIn || !arIn || !target || !enIn.value.trim() || !arIn.value.trim()) return;

    target.insertAdjacentHTML('beforeend', getSimpleOptionRowTemplate(
        enIn.value.trim(),
        arIn.value.trim(),
        parseFloat(prIn.value) || 0,
        parseInt(stIn.value) || 0
    ));

    enIn.value = ""; arIn.value = ""; prIn.value = "0.00"; stIn.value = "0";
    reindexFormAttributes();
}

function addMainOption(vIdx) {
    const enIn = document.getElementById(`main_input_en_${vIdx}`);
    const arIn = document.getElementById(`main_input_ar_${vIdx}`);
    const target = document.getElementById(`main_options_container_${vIdx}`);

    if (!enIn || !arIn || !target || !enIn.value.trim() || !arIn.value.trim()) return;

    const oIdx = target.querySelectorAll('.main-option-group').length;
    target.insertAdjacentHTML('beforeend', getMainOptionTemplate(vIdx, oIdx, enIn.value.trim(), arIn.value.trim()));

    enIn.value = ""; arIn.value = "";
    reindexFormAttributes();
}

function addSubVariant(vIdx, oIdx) {
    const enIn = document.getElementById(`sub_var_input_en_${vIdx}_${oIdx}`);
    const arIn = document.getElementById(`sub_var_input_ar_${vIdx}_${oIdx}`);
    const target = document.getElementById(`sub_variants_container_${vIdx}_${oIdx}`);

    if (!enIn || !arIn || !target || !enIn.value.trim() || !arIn.value.trim()) return;

    const svIdx = target.querySelectorAll('.sub-variant-group').length;
    target.insertAdjacentHTML('beforeend', getSubVariantTemplate(vIdx, oIdx, svIdx, enIn.value.trim(), arIn.value.trim()));

    enIn.value = ""; arIn.value = "";
    reindexFormAttributes();
}

function addSubOption(vIdx, oIdx, svIdx) {
    const enIn = document.getElementById(`sub_opt_input_en_${vIdx}_${oIdx}_${svIdx}`);
    const arIn = document.getElementById(`sub_opt_input_ar_${vIdx}_${oIdx}_${svIdx}`);
    const prIn = document.getElementById(`sub_opt_input_price_${vIdx}_${oIdx}_${svIdx}`);
    const stIn = document.getElementById(`sub_opt_input_stock_${vIdx}_${oIdx}_${svIdx}`);
    const target = document.getElementById(`sub_options_container_${vIdx}_${oIdx}_${svIdx}`);

    if (!enIn || !arIn || !target || !enIn.value.trim() || !arIn.value.trim()) return;

    target.insertAdjacentHTML('beforeend', getSubOptionRowTemplate(
        enIn.value.trim(),
        arIn.value.trim(),
        parseFloat(prIn.value) || 0,
        parseInt(stIn.value) || 0
    ));

    enIn.value = ""; arIn.value = ""; prIn.value = "0.00"; stIn.value = "0";
    reindexFormAttributes();
}

function removeSimpleVariant(idx) {
    document.getElementById(`simple_card_${idx}`)?.remove();
    reindexFormAttributes();
}

function removeVariant(idx) {
    document.getElementById(`variant_card_${idx}`)?.remove();
    reindexFormAttributes();
}

function genericReindex() {
    reindexFormAttributes();
}


function reindexFormAttributes() {
    if (productMode === "simple") {
        const cards = document.querySelectorAll('.simple-variant-card');
        cards.forEach((card, vIdx) => {
            card.querySelectorAll('[data-simple-type]').forEach(input => {
                const type = input.getAttribute('data-simple-type');
                input.setAttribute('name', `SimpleProductVariants[${vIdx}].${type}`);
            });

            const rows = card.querySelectorAll('.simple-option-row');
            rows.forEach((row, oIdx) => {
                row.querySelectorAll('[data-simple-opt-type]').forEach(input => {
                    const type = input.getAttribute('data-simple-opt-type');
                    input.setAttribute('name', `SimpleProductVariants[${vIdx}].Options[${oIdx}].${type}`);
                });
            });
        });
    } else {
        const cards = document.querySelectorAll('.variant-item-card');
        cards.forEach((card, vIdx) => {
            card.querySelectorAll('[data-name-type]').forEach(input => {
                const type = input.getAttribute('data-name-type');
                input.setAttribute('name', `NestedProductVariants[${vIdx}].${type}`);
            });

            const mainOpts = card.querySelectorAll('.main-option-group');
            mainOpts.forEach((mOpt, oIdx) => {
                mOpt.querySelectorAll('[data-opt-type]').forEach(input => {
                    const type = input.getAttribute('data-opt-type');
                    input.setAttribute('name', `NestedProductVariants[${vIdx}].Options[${oIdx}].${type}`);
                });

                const subVars = mOpt.querySelectorAll('.sub-variant-group');
                subVars.forEach((sVar, svIdx) => {
                    sVar.querySelectorAll('[data-subvar-type]').forEach(input => {
                        const type = input.getAttribute('data-subvar-type');
                        input.setAttribute('name', `NestedProductVariants[${vIdx}].Options[${oIdx}].SubVariants[${svIdx}].${type}`);
                    });

                    const subOpts = sVar.querySelectorAll('.sub-option-row');
                    subOpts.forEach((sOpt, soIdx) => {
                        sOpt.querySelectorAll('[data-sub-type]').forEach(input => {
                            const type = input.getAttribute('data-sub-type');
                            input.setAttribute('name', `NestedProductVariants[${vIdx}].Options[${oIdx}].SubVariants[${svIdx}].SubOptions[${soIdx}].${type}`);
                        });
                    });
                });
            });
        });
    }
}

function attachFormSubmitListener() {
    const form = document.querySelector('form');
    if (!form || form.dataset.listenerAttached === "true") return;

    form.addEventListener('submit', function (event) {
        event.preventDefault();

        reindexFormAttributes();

        this.submit();
    });

    form.dataset.listenerAttached = "true";
}

window.ProductVariantsManager = {
    initWithData: initWithData,
    addSimpleVariantCard: addSimpleVariantCard,
    addNestedVariantCard: addNestedVariantCard,
    addSimpleOption: addSimpleOption,
    addMainOption: addMainOption,
    addSubVariant: addSubVariant,
    addSubOption: addSubOption,
    removeSimpleVariant: removeSimpleVariant,
    removeVariant: removeVariant,
    reindex: genericReindex,

    init: function (initialMode) {
        productMode = initialMode || "simple";
        const hasNestedInput = document.getElementById("HasNestedVariantsInput");
        if (hasNestedInput) hasNestedInput.value = (productMode === "nested");
        initWithData([], productMode === "nested");
    },

    switchMode: function (mode) {
        if (!confirm("Switching modes will clear your current added variants config. Proceed?")) {
            const configModeInput = document.getElementById("VariantConfigMode");
            if (configModeInput) configModeInput.value = productMode;
            return;
        }
        productMode = mode;
        const hasNestedInput = document.getElementById("HasNestedVariantsInput");
        if (hasNestedInput) hasNestedInput.value = (productMode === "nested");

        initWithData([], productMode === "nested");
    },

    addMainItem: function () {
        if (productMode === "simple") {
            this.addSimpleVariantCard();
        } else {
            this.addNestedVariantCard();
        }
    }
};