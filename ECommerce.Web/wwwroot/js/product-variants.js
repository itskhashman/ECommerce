(function () {
    let variantIndex = 0;

    function getVariantCardTemplate(index, variantData = null) {
        const nameEn = variantData ? variantData.nameEn || variantData.NameEn || '' : '';
        const nameAr = variantData ? variantData.nameAr || variantData.NameAr || '' : '';
        const id = variantData ? variantData.id || variantData.Id || 0 : 0;
        const productId = variantData ? variantData.productId || variantData.ProductId || 0 : 0;

        return `
            <div class="card shadow-sm mb-4 border-secondary variant-item-card" id="variant_card_${index}">
                <div class="card-body p-3">
                    <input type="hidden" data-name-type="Id" value="${id}" />
                    <input type="hidden" data-name-type="ProductId" value="${productId}" />

                    <div class="row align-items-center mb-3">
                        <div class="col-md-4 mb-2 mb-md-0">
                            <label class="form-label fw-bold text-secondary">Variant Name (English)</label>
                            <input type="text" data-name-type="NameEn" class="form-control" placeholder="e.g., Size, Color" value="${nameEn}" required />
                        </div>
                        <div class="col-md-4 mb-2 mb-md-0">
                            <label class="form-label fw-bold text-secondary text-end d-block">Variant Name (Arabic)</label>
                            <input type="text" data-name-type="NameAr" class="form-control text-end" placeholder="مثال: المقاس، اللون" value="${nameAr}" required dir="rtl" />
                        </div>
                        <div class="col-md-4 col-12 text-end mt-4">
                            <button type="button" class="btn btn-sm btn-outline-danger" onclick="window.ProductVariantsManager.removeVariant(${index})">
                                <i class="bi bi-trash me-1"></i>Remove Variant
                            </button>
                        </div>
                    </div>

                    <div class="bg-white p-3 rounded border">
                        <label class="form-label small fw-bold text-muted d-block mb-2">Variant Options / خيارات المتغير</label>
                        <div class="d-flex flex-wrap gap-2 align-items-center">
                            <div class="d-flex flex-wrap gap-2 badge-container" id="badge_container_${index}" data-option-count="0"></div>
                            <div class="input-group input-group-sm m-0" style="max-width: 450px;">
                                <input type="text" class="form-control" id="input_field_en_${index}" placeholder="Value (EN) e.g. Red" />
                                <input type="text" class="form-control text-end" id="input_field_ar_${index}" placeholder="القيمة (عربي) مثال: أحمر" dir="rtl" />
                                <button class="btn btn-secondary" type="button" onclick="window.ProductVariantsManager.addOption(${index})">Add</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>`;
    }

    function getOptionBadgeTemplate(valueEn, valueAr, optionIndex, id = 0, variantId = 0) {
        return `
            <div class="badge bg-primary d-flex align-items-center p-2 fs-6 fw-normal text-white">
                <span class="me-1">${valueEn}</span>
                <span class="mx-1 text-white-50">|</span>
                <span class="ms-1" dir="rtl">${valueAr}</span>

                <input type="hidden" data-option-type="Id" value="${id}" />
                <input type="hidden" data-option-type="ProductVariantId" value="${variantId}" />
                <input type="hidden" data-option-type="NameEn" value="${valueEn}" />
                <input type="hidden" data-option-type="NameAr" value="${valueAr}" />

                <button type="button" class="btn-close btn-close-white ms-2 small" onclick="this.parentElement.remove(); window.ProductVariantsManager.reindex();" style="font-size: 0.65rem;"></button>
            </div>`;
    }

    function init(initialCount = 0) {
        variantIndex = initialCount;
        attachFormSubmitListener();
    }

    function initWithData(existingVariants) {
        const container = document.getElementById("variantsList");
        if (!container || !existingVariants || !existingVariants.length) return;

        container.innerHTML = "";

        existingVariants.forEach((variant) => {
            const variantHtml = getVariantCardTemplate(variantIndex, variant);
            container.insertAdjacentHTML('beforeend', variantHtml);

            const badgeContainer = document.getElementById(`badge_container_${variantIndex}`);
            const optionsList = variant.productVariantOptions || variant.ProductVariantOptions || [];

            optionsList.forEach((opt, oIdx) => {
                const optEn = opt.nameEn || opt.NameEn;
                const optAr = opt.nameAr || opt.NameAr;
                const optId = opt.id || opt.Id || 0;
                const vId = opt.productVariantId || opt.ProductVariantId || 0;

                const badgeHtml = getOptionBadgeTemplate(optEn, optAr, oIdx, optId, vId);
                badgeContainer.insertAdjacentHTML('beforeend', badgeHtml);
            });

            badgeContainer.setAttribute("data-option-count", optionsList.length);
            variantIndex++;
        });

        reindexFormAttributes();
        attachFormSubmitListener();
    }

    function addVariant() {
        const container = document.getElementById("variantsList");
        if (!container) return;

        const variantCardHtml = getVariantCardTemplate(variantIndex);
        container.insertAdjacentHTML('beforeend', variantCardHtml);

        reindexFormAttributes();
        variantIndex++;
    }

    function addOption(cardId) {
        const inputFieldEn = document.getElementById(`input_field_en_${cardId}`);
        const inputFieldAr = document.getElementById(`input_field_ar_${cardId}`);
        const badgeContainer = document.getElementById(`badge_container_${cardId}`);

        if (!inputFieldEn || !inputFieldAr || !badgeContainer) return;

        const valueEn = inputFieldEn.value.trim();
        const valueAr = inputFieldAr.value.trim();

        if (!valueEn || !valueAr) {
            alert("Please fill out both English and Arabic values for the option.");
            return;
        }

        const optionIndex = parseInt(badgeContainer.getAttribute("data-option-count")) || 0;
        const badgeHtml = getOptionBadgeTemplate(valueEn, valueAr, optionIndex);

        badgeContainer.insertAdjacentHTML('beforeend', badgeHtml);
        badgeContainer.setAttribute("data-option-count", optionIndex + 1);

        inputFieldEn.value = "";
        inputFieldAr.value = "";

        reindexFormAttributes();
    }

    function removeVariant(cardId) {
        const element = document.getElementById(`variant_card_${cardId}`);
        if (element && confirm("Are you sure you want to delete this variant?")) {
            element.remove();
            reindexFormAttributes();
        }
    }

    function reindexFormAttributes() {
        const variantCards = document.querySelectorAll('.variant-item-card');

        variantCards.forEach((card, vIdx) => {
            const idInput = card.querySelector('input[data-name-type="Id"]');
            const prodIdInput = card.querySelector('input[data-name-type="ProductId"]');
            const nameEnInput = card.querySelector('input[data-name-type="NameEn"]');
            const nameArInput = card.querySelector('input[data-name-type="NameAr"]');

            if (idInput) idInput.name = `ProductVariants[${vIdx}].Id`;
            if (prodIdInput) prodIdInput.name = `ProductVariants[${vIdx}].ProductId`;
            if (nameEnInput) nameEnInput.name = `ProductVariants[${vIdx}].NameEn`;
            if (nameArInput) nameArInput.name = `ProductVariants[${vIdx}].NameAr`;

            const badgeContainer = card.querySelector('.badge-container');
            if (badgeContainer) {
                const optionBadges = badgeContainer.children;

                Array.from(optionBadges).forEach((badge, oIdx) => {
                    const optId = badge.querySelector('input[data-option-type="Id"]');
                    const optVId = badge.querySelector('input[data-option-type="ProductVariantId"]');
                    const enHidden = badge.querySelector('input[data-option-type="NameEn"]');
                    const arHidden = badge.querySelector('input[data-option-type="NameAr"]');

                    if (optId) optId.name = `ProductVariants[${vIdx}].ProductVariantOptions[${oIdx}].Id`;
                    if (optVId) optVId.name = `ProductVariants[${vIdx}].ProductVariantOptions[${oIdx}].ProductVariantId`;
                    if (enHidden) enHidden.name = `ProductVariants[${vIdx}].ProductVariantOptions[${oIdx}].NameEn`;
                    if (arHidden) arHidden.name = `ProductVariants[${vIdx}].ProductVariantOptions[${oIdx}].NameAr`;
                });
            }
        });
    }

    function attachFormSubmitListener() {
        const form = document.querySelector('form');
        if (form) {
            form.removeEventListener('submit', reindexFormAttributes);
            form.addEventListener('submit', reindexFormAttributes);
        }
    }

    window.ProductVariantsManager = {
        init: init,
        initWithData: initWithData,
        addVariant: addVariant,
        addOption: addOption,
        removeVariant: removeVariant,
        reindex: reindexFormAttributes
    };
})();