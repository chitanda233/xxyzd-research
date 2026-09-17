package com.sigmob.sdk.base.views.gif;

import android.graphics.Bitmap;

/* JADX INFO: loaded from: classes3.dex */
public class f implements a.InterfaceC0558a {
    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public Bitmap a(int width, int height, Bitmap.Config config) {
        return Bitmap.createBitmap(width, height, config);
    }

    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public void a(Bitmap bitmap) {
        bitmap.recycle();
    }

    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public void a(byte[] bytes) {
    }

    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public void a(int[] array) {
    }

    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public byte[] a(int size) {
        return new byte[size];
    }

    @Override // com.sigmob.sdk.base.views.gif.a.InterfaceC0558a
    public int[] b(int size) {
        return new int[size];
    }
}
