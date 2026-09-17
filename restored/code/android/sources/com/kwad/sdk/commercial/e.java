package com.kwad.sdk.commercial;

import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.br;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    public static int dj(int i) {
        if (i == -1) {
            return 100010;
        }
        if (i == -2) {
            return 100011;
        }
        return i;
    }

    public static BusinessType bw(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return BusinessType.OTHER;
        }
        return di(com.kwad.sdk.core.response.helper.e.eG(adTemplate));
    }

    public static BusinessType di(int i) {
        if (i == 3) {
            return BusinessType.AD_FULLSCREEN;
        }
        if (i == 2) {
            return BusinessType.AD_REWARD;
        }
        if (i == 4) {
            return BusinessType.AD_SPLASH;
        }
        if (i == 13 || i == 23) {
            return BusinessType.AD_INTERSTITIAL;
        }
        if (i == 1) {
            return BusinessType.AD_FEED;
        }
        if (i == 10000) {
            return BusinessType.AD_NATIVE;
        }
        return BusinessType.OTHER;
    }

    /* JADX WARN: Code duplicated, block: B:23:0x0038  */
    public static AdMatrixInfo.MatrixTemplate bx(AdTemplate adTemplate) {
        String str;
        AdMatrixInfo.MatrixTemplate matrixTemplateT = null;
        if (adTemplate.mAdScene == null) {
            return null;
        }
        AdMatrixInfo.AdDataV2 adDataV2 = com.kwad.sdk.core.response.helper.b.cJ(adTemplate).adDataV2;
        int iEG = com.kwad.sdk.core.response.helper.e.eG(adTemplate);
        if (iEG == 2) {
            str = adDataV2.neoTKInfo.templateId;
        } else if (iEG == 3) {
            str = adDataV2.fullScreenInfo.templateId;
        } else if (iEG == 4) {
            str = adDataV2.splashPlayCardTKInfo.templateId;
        } else if (iEG == 6) {
            str = adDataV2.drawTKCardInfo.templateId;
        } else if (iEG == 13) {
            str = adDataV2.interstitialCardInfo.templateId;
        } else if (iEG == 23) {
            int iFe = com.kwad.sdk.core.response.helper.e.fe(adTemplate);
            if (iFe == 1) {
                str = adDataV2.fullScreenInfo.templateId;
            } else if (iFe == 2) {
                str = adDataV2.interstitialCardInfo.templateId;
            } else {
                str = "";
            }
        } else {
            str = "";
        }
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        for (AdMatrixInfo.MatrixTemplate matrixTemplate : com.kwad.sdk.core.response.helper.b.cK(adTemplate)) {
            if (br.isEquals(str, matrixTemplate.templateId)) {
                matrixTemplateT = matrixTemplate;
                break;
            }
        }
        if (matrixTemplateT == null) {
            matrixTemplateT = com.kwad.sdk.core.response.helper.b.t(adTemplate, str);
        }
        if (matrixTemplateT != null) {
            matrixTemplateT.publishType = ((h) ServiceProvider.get(h.class)).cP(a(matrixTemplateT));
        }
        return matrixTemplateT;
    }

    private static String a(AdMatrixInfo.MatrixTemplate matrixTemplate) {
        StringBuffer stringBuffer = new StringBuffer();
        stringBuffer.append(matrixTemplate.templateId).append("#").append(matrixTemplate.templateVersionCode);
        return stringBuffer.toString();
    }
}
