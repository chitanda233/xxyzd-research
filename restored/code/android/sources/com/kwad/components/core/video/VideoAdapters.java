package com.kwad.components.core.video;

import android.view.View;
import android.view.ViewGroup;

/* JADX INFO: loaded from: classes3.dex */
public final class VideoAdapters {

    enum AdaptType {
        PORTRAIT_VERTICAL,
        PORTRAIT_HORIZONTAL,
        LANDSCAPE_VERTICAL,
        LANDSCAPE_HORIZONTAL
    }

    public static abstract class a implements com.kwad.components.core.video.c {
        protected abstract void a(AdaptType adaptType, ViewGroup.LayoutParams layoutParams, d dVar, d dVar2);

        @Override // com.kwad.components.core.video.c
        public final void a(final View view, View view2, int i, int i2) {
            AdaptType adaptType;
            if (!b(view, view2, i, i2)) {
                com.kwad.sdk.core.d.c.d("AbstractVideoViewAdapter", "adaptVideo checkArguments invalid");
                return;
            }
            d dVar = new d(view2.getWidth(), view2.getHeight());
            d dVar2 = new d(i, i2);
            boolean z = dVar2.getRatio() >= 1.0f;
            boolean z2 = dVar.getRatio() >= 1.0f;
            if (z2 && z) {
                adaptType = AdaptType.PORTRAIT_VERTICAL;
            } else if (z2) {
                adaptType = AdaptType.PORTRAIT_HORIZONTAL;
            } else if (z) {
                adaptType = AdaptType.LANDSCAPE_VERTICAL;
            } else {
                adaptType = AdaptType.LANDSCAPE_HORIZONTAL;
            }
            final ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
            a(adaptType, layoutParams, dVar, dVar2);
            if (F(view)) {
                view.post(new Runnable() { // from class: com.kwad.components.core.video.VideoAdapters.a.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        view.setLayoutParams(layoutParams);
                    }
                });
            } else {
                view.setLayoutParams(layoutParams);
            }
        }

        private static boolean F(View view) {
            return view.isInLayout() || view.isLayoutRequested();
        }

        private static boolean b(View view, View view2, int i, int i2) {
            if (view == null || i == 0 || i2 == 0 || view2 == null) {
                return false;
            }
            return (view2.getWidth() == 0 || view2.getHeight() == 0) ? false : true;
        }
    }

    public static class c extends a {
        @Override // com.kwad.components.core.video.VideoAdapters.a
        protected final void a(AdaptType adaptType, ViewGroup.LayoutParams layoutParams, d dVar, d dVar2) {
            float fXZ;
            float fYa;
            float fYb = dVar.yb();
            float fYb2 = dVar2.yb();
            int i = AnonymousClass1.anL[adaptType.ordinal()];
            if (i == 1 || i == 2) {
                if (fYb >= fYb2) {
                    fYa = dVar.ya();
                    fXZ = fYa * fYb2;
                } else {
                    fXZ = dVar.xZ();
                    fYa = fXZ / fYb2;
                }
            } else if (i == 3 || i == 4) {
                fXZ = dVar.ya();
                fYa = fXZ / fYb2;
            } else {
                fXZ = 0.0f;
                fYa = -2.1474836E9f;
            }
            if (fYa == -2.1474836E9f || fXZ == -2.1474836E9f) {
                return;
            }
            if (dVar2.getHeight() > dVar2.getWidth()) {
                layoutParams.width = (int) fYa;
                layoutParams.height = (int) fXZ;
            } else {
                layoutParams.height = (int) fYa;
                layoutParams.width = (int) fXZ;
            }
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.core.video.VideoAdapters$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {
        static final /* synthetic */ int[] anL;

        static {
            int[] iArr = new int[AdaptType.values().length];
            anL = iArr;
            try {
                iArr[AdaptType.PORTRAIT_VERTICAL.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                anL[AdaptType.LANDSCAPE_HORIZONTAL.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                anL[AdaptType.PORTRAIT_HORIZONTAL.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                anL[AdaptType.LANDSCAPE_VERTICAL.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
        }
    }

    public static class b extends a {
        private float anO = 0.8f;
        private float anP = 0.9375f;
        private float anQ = 1.1046f;

        @Override // com.kwad.components.core.video.VideoAdapters.a
        protected final void a(AdaptType adaptType, ViewGroup.LayoutParams layoutParams, d dVar, d dVar2) {
            float fYa;
            float f;
            float fYb = dVar.yb();
            float fYb2 = dVar2.yb();
            float fYa2 = dVar.ya();
            float fXZ = dVar.xZ();
            com.kwad.sdk.core.d.c.d("FullHeightAdapter", "onAdaptVideo containerSize: " + fXZ + ", " + fYa2);
            int i = AnonymousClass1.anL[adaptType.ordinal()];
            if (i == 1 || i == 2) {
                if (fYb > fYb2) {
                    float fXZ2 = dVar.xZ();
                    float f2 = fXZ2 / fYb2;
                    float f3 = fYa2 / f2;
                    float f4 = this.anO;
                    if (f3 >= f4) {
                        f = fXZ2;
                        fYa = f2;
                    } else {
                        fYa = fYa2 / f4;
                        f = fYa * fYb2;
                    }
                } else {
                    fYa = dVar.ya();
                    f = fYb2 * fYa;
                    float f5 = fXZ / f;
                    float f6 = this.anP;
                    if (f5 < f6) {
                        f = fXZ / f6;
                        fYa = f / fYb2;
                    }
                }
            } else if (i == 3 || i == 4) {
                f = fYa2 * this.anQ;
                fYa = f / fYb2;
            } else {
                fYa = -2.1474836E9f;
                f = -2.1474836E9f;
            }
            com.kwad.sdk.core.d.c.d("FullHeightAdapter", "onAdaptVideo result: " + f + ", " + fYa);
            if (f == -2.1474836E9f || fYa == -2.1474836E9f) {
                return;
            }
            if (dVar2.getHeight() >= dVar2.getWidth()) {
                layoutParams.width = (int) fYa;
                layoutParams.height = (int) f;
            } else {
                layoutParams.height = (int) fYa;
                layoutParams.width = (int) f;
            }
        }
    }

    static class d {
        float anR;
        float height;
        float width;

        public d(float f, float f2) {
            this.anR = -1.0f;
            this.width = f;
            this.height = f2;
            if (f <= 0.0f || f2 <= 0.0f) {
                return;
            }
            this.anR = f2 / f;
        }

        private boolean isValid() {
            return this.width > 0.0f && this.height > 0.0f;
        }

        public final float getWidth() {
            return this.width;
        }

        public final float getHeight() {
            return this.height;
        }

        public final float getRatio() {
            return this.anR;
        }

        public final float xZ() {
            if (isValid()) {
                return Math.max(this.width, this.height);
            }
            return -1.0f;
        }

        public final float ya() {
            if (isValid()) {
                return Math.min(this.width, this.height);
            }
            return -1.0f;
        }

        public final float yb() {
            if (!isValid()) {
                return -1.0f;
            }
            float f = this.height;
            float f2 = this.width;
            return f > f2 ? f / f2 : f2 / f;
        }

        public final String toString() {
            return "ViewSize{width=" + this.width + ", height=" + this.height + ", ratio=" + this.anR + '}';
        }
    }
}
