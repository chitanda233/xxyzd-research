package com.tencent.turingfd.sdk.ams.ad;

import android.content.ComponentName;
import android.content.Context;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.util.SparseArray;
import java.lang.reflect.InvocationHandler;
import java.util.Map;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public class TNative$aa {

    public static class bb implements ServiceConnection {
        @Override // android.content.ServiceConnection
        public native void onServiceConnected(ComponentName componentName, IBinder iBinder);

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }
    }

    public static native SparseArray<Object> a209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map, Map<Integer, String> map2, int i);

    public static native SparseArray<Object> b209308_501191CEF186C29F(SparseArray<Object> sparseArray, byte[] bArr, Map<String, String> map, int i);

    public static native SparseArray<Object> c209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context);

    public static native SparseArray<Object> d209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, int i);

    public static native SparseArray<Object> e209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map, int i);

    public static native SparseArray<Object> f209308_501191CEF186C29F(SparseArray<Object> sparseArray, byte[] bArr, int i);

    public static native SparseArray<Object> g209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map, int i);

    public static native SparseArray<Object> h209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map, int i);

    public static native SparseArray<Object> i209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map, Object obj, Object obj2, Object obj3);

    public static native String j209308_501191CEF186C29F();

    public static native byte[] k209308_501191CEF186C29F(byte[] bArr);

    public static native void l209308_501191CEF186C29F(InvocationHandler invocationHandler, AtomicReference<Object> atomicReference, ClassLoader classLoader);

    public static native SparseArray<Object> m209308_501191CEF186C29F(SparseArray<Object> sparseArray, Context context, Map<String, String> map);

    public static native SparseArray<Object> n209308_501191CEF186C29F(SparseArray<Object> sparseArray, byte[] bArr, int i, String str, long j);

    public static native SparseArray<Object> o209308_501191CEF186C29F(SparseArray<Object> sparseArray, String str, String str2, byte[] bArr, Map<String, String> map, String str3, byte[] bArr2, byte[] bArr3, byte[] bArr4, String str4);

    public static native SparseArray<Object> p209308_501191CEF186C29F(SparseArray<Object> sparseArray, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4);

    public static native long q1209308_501191CEF186C29F(String str);

    public static native byte[] q2209308_501191CEF186C29F(long j, byte[] bArr, String str);

    public static native byte[] q3209308_501191CEF186C29F(byte[] bArr, byte[] bArr2);

    public static native byte[] q4209308_501191CEF186C29F(byte[] bArr, byte[] bArr2);
}
