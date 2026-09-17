package com.kwad.sdk.core.response.helper;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class SlideConvertHelper {
    public static boolean a(AdTemplate adTemplate, float f, float f2, float f3, float f4) {
        SlideDirection slideDirection;
        AdInfo adInfoEM = e.eM(adTemplate);
        boolean zEB = d.eB(adTemplate);
        String strAs = a.as(adInfoEM);
        int iAr = a.ar(adInfoEM);
        double d = f3 - f;
        double d2 = f4 - f2;
        float fPx2dip = com.kwad.sdk.c.a.a.px2dip(ServiceProvider.getContext(), (float) Math.sqrt(Math.pow(d, 2.0d) + Math.pow(d2, 2.0d)));
        if (Math.abs(d) >= Math.abs(d2)) {
            slideDirection = d > 0.0d ? SlideDirection.RIGHT : SlideDirection.LEFT;
        } else {
            slideDirection = d2 > 0.0d ? SlideDirection.DOWN : SlideDirection.UP;
        }
        return zEB && fPx2dip > ((float) iAr) && strAs.charAt(slideDirection.value) == '1';
    }

    public enum SlideDirection {
        UP(0),
        DOWN(1),
        LEFT(2),
        RIGHT(3);

        public int value;

        SlideDirection(int i) {
            this.value = i;
        }
    }
}
