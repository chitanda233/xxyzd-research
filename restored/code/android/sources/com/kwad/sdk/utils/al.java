package com.kwad.sdk.utils;

import android.content.Context;
import android.text.TextUtils;
import com.sigmob.sdk.base.models.SigMacroCommon;

/* JADX INFO: loaded from: classes3.dex */
public final class al {
    public static String d(Context context, String str, boolean z) {
        return str.replace("__TS__", String.valueOf(bv.C(context, z)));
    }

    public static String a(String str, a aVar) {
        return (TextUtils.isEmpty(str) || aVar == null) ? str : str.replace("__WIDTH__", fN(aVar.getWidth())).replace("__HEIGHT__", fN(aVar.getHeight())).replace("__DOWN_X__", fN(aVar.VN())).replace("__DOWN_Y__", fN(aVar.VO())).replace("__UP_X__", fN(aVar.VP())).replace("__UP_Y__", fN(aVar.VQ()));
    }

    public static String av(Context context, String str) {
        return TextUtils.isEmpty(str) ? str : str.replace("__SCREEN_WIDTH__", String.valueOf(n.getScreenWidth(context))).replace("__SCREEN_HEIGHT__", String.valueOf(n.getScreenHeight(context))).replace("__DEVICE_WIDTH__", String.valueOf(n.dc(context))).replace("__DEVICE_HEIGHT__", String.valueOf(n.dd(context)));
    }

    private static String fN(int i) {
        return i >= 0 ? String.valueOf(i) : SigMacroCommon.DEFAULT_XY;
    }

    public static class a {
        private int bpv;
        private int bpw;
        private int bpx;
        private int bpy;
        private int mHeight;
        private int mWidth;

        public a() {
            this.mWidth = -1;
            this.mHeight = -1;
            this.bpv = -1;
            this.bpw = -1;
            this.bpx = -1;
            this.bpy = -1;
        }

        public a(int i, int i2) {
            this.bpv = -1;
            this.bpw = -1;
            this.bpx = -1;
            this.bpy = -1;
            this.mWidth = i;
            this.mHeight = i2;
        }

        public final void j(float f, float f2) {
            this.bpv = (int) f;
            this.bpw = (int) f2;
        }

        public final void k(float f, float f2) {
            this.bpx = (int) f;
            this.bpy = (int) f2;
        }

        public final void H(int i, int i2) {
            this.mWidth = i;
            this.mHeight = i2;
        }

        public final int getWidth() {
            return this.mWidth;
        }

        public final int getHeight() {
            return this.mHeight;
        }

        public final int VN() {
            return this.bpv;
        }

        public final int VO() {
            return this.bpw;
        }

        public final int VP() {
            return this.bpx;
        }

        public final int VQ() {
            return this.bpy;
        }

        public final String toString() {
            return "TouchCoords{mWidth=" + this.mWidth + ", mHeight=" + this.mHeight + ", mDownX=" + this.bpv + ", mDownY=" + this.bpw + ", mUpX=" + this.bpx + ", mUpY=" + this.bpy + '}';
        }
    }
}
