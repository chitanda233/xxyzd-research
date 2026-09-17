package com.kwad.components.ad.splashscreen;

import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public static int Gx;
    private String Gy;
    private int Gz = 2;

    public static d a(AdTemplate adTemplate, AdInfo adInfo, com.kwad.components.core.e.d.d dVar, int i) {
        d dVar2 = new d();
        Gx = i;
        if (adInfo != null && dVar != null) {
            if (i == 1 || i == 4) {
                dVar2.ab(a(adTemplate, adInfo, dVar));
            } else if (i == 10) {
                if (com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
                    int iQm = dVar.qm();
                    if (iQm == 2) {
                        dVar2.ab(a(adTemplate, adInfo, iQm, 0));
                    } else {
                        dVar2.ab("扭动或点击" + a(adTemplate, adInfo, iQm, 0));
                    }
                } else {
                    try {
                        String strDU = com.kwad.sdk.core.response.helper.b.dU(adInfo);
                        if (!TextUtils.isEmpty(strDU)) {
                            dVar2.ab("扭动或点击" + strDU);
                        } else {
                            dVar2.ab("或点击跳转详情页或第三方应用");
                        }
                    } catch (Exception unused) {
                        dVar2.ab("或点击跳转详情页或第三方应用");
                    }
                }
            } else if (com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
                dVar2.ab("或点击" + a(adTemplate, adInfo, dVar.qm(), 0));
            } else {
                String strA = com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hd);
                if (TextUtils.isEmpty(strA)) {
                    strA = "点击跳转详情页或第三方应用";
                }
                dVar2.ab("或" + strA);
            }
        }
        dVar2.al(com.kwad.sdk.core.response.helper.b.eb(adInfo));
        return dVar2;
    }

    public static String a(AdTemplate adTemplate, AdInfo adInfo, int i, int i2) {
        String strAK = com.kwad.sdk.core.response.helper.a.aK(adInfo);
        if (i == 2) {
            return i2 + "%";
        }
        if (i == 4) {
            return "继续下载";
        }
        if (i != 8) {
            return i != 12 ? strAK : com.kwad.sdk.core.response.helper.a.af(adInfo);
        }
        return com.kwad.sdk.core.response.helper.a.cF(adTemplate);
    }

    private static String a(AdInfo adInfo, int i) {
        if (i == 1) {
            return com.kwad.sdk.core.response.helper.b.dU(adInfo) != null ? com.kwad.sdk.core.response.helper.b.dU(adInfo) : "";
        }
        return (i != 4 || com.kwad.sdk.core.response.helper.b.dV(adInfo) == null) ? "" : com.kwad.sdk.core.response.helper.b.dV(adInfo);
    }

    private static String a(AdTemplate adTemplate, AdInfo adInfo, com.kwad.components.core.e.d.d dVar) {
        if (com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
            return a(adTemplate, adInfo, dVar.qm(), 0);
        }
        String strA = a(adInfo, Gx);
        return TextUtils.isEmpty(strA) ? "点击跳转详情页或第三方应用" : strA;
    }

    public final String lU() {
        return this.Gy;
    }

    private void ab(String str) {
        this.Gy = str;
    }

    public final int lV() {
        return this.Gz;
    }

    private void al(int i) {
        this.Gz = i;
    }
}
