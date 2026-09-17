package com.tencent.turingfd.sdk.ams.ad;

import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes4.dex */
public final class Sugarcane extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ IBinder f3895a;
    public final /* synthetic */ Sultana b;

    public Sugarcane(Sultana sultana, IBinder iBinder) {
        this.b = sultana;
        this.f3895a = iBinder;
    }

    /* JADX WARN: Code duplicated, block: B:15:0x002a A[Catch: all -> 0x00ca, TRY_LEAVE, TryCatch #5 {all -> 0x00ca, blocks: (B:13:0x0021, B:15:0x002a, B:17:0x0048, B:19:0x0051, B:20:0x0057, B:16:0x0032), top: B:62:0x0021, inners: #0 }] */
    /* JADX WARN: Code duplicated, block: B:21:0x0058  */
    /* JADX WARN: Code duplicated, block: B:24:0x0067 A[Catch: all -> 0x00c7, TryCatch #3 {all -> 0x00c7, blocks: (B:22:0x0059, B:24:0x0067, B:25:0x007d, B:27:0x009a), top: B:59:0x0059 }] */
    /* JADX WARN: Code duplicated, block: B:25:0x007d A[Catch: all -> 0x00c7, TRY_LEAVE, TryCatch #3 {all -> 0x00c7, blocks: (B:22:0x0059, B:24:0x0067, B:25:0x007d, B:27:0x009a), top: B:59:0x0059 }] */
    /* JADX WARN: Code duplicated, block: B:54:0x00fa A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:56:0x00e7 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:64:? A[RETURN, SYNTHETIC] */
    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        Lacerta gemini;
        Lacerta lacerta;
        int i;
        Gemini gemini2;
        int i2;
        int i3;
        Syrup syrupA;
        int i4;
        Parcel parcelObtain;
        Parcel parcelObtain2;
        Parcel parcelObtain3;
        Parcel parcelObtain4;
        IBinder iBinder = this.f3895a;
        try {
            try {
                if (iBinder != null) {
                    IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(Hydra.f3857a);
                    if (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof Lacerta)) {
                        gemini = new Gemini(iBinder);
                    } else {
                        lacerta = (Lacerta) iInterfaceQueryLocalInterface;
                    }
                    gemini2 = (Gemini) gemini;
                    if (gemini2.b()) {
                        i2 = 0;
                    } else {
                        parcelObtain3 = Parcel.obtain();
                        parcelObtain4 = Parcel.obtain();
                        try {
                            parcelObtain3.writeInterfaceToken(Hydra.f3857a);
                            parcelObtain3.writeInt(2000);
                            gemini2.f3850a.transact(1, parcelObtain3, parcelObtain4, 0);
                            parcelObtain4.readException();
                            parcelObtain4.readInt();
                            parcelObtain4.recycle();
                            parcelObtain3.recycle();
                            i2 = 1;
                        } catch (Throwable th) {
                            parcelObtain4.recycle();
                            parcelObtain3.recycle();
                            throw th;
                        }
                    }
                    syrupA = Tangerine.a(gemini2.a().b);
                    i4 = syrupA.f3897a;
                    if (i4 != 0) {
                        this.b.f3896a.set(new Segment(i4, 200, -1L, "", -1, i2));
                    } else {
                        Strawberry strawberry = syrupA.b;
                        parcelObtain = Parcel.obtain();
                        parcelObtain2 = Parcel.obtain();
                        try {
                            try {
                                parcelObtain.writeInterfaceToken(Hydra.f3857a);
                                gemini2.f3850a.transact(12, parcelObtain, parcelObtain2, 0);
                                parcelObtain2.readException();
                                int i5 = parcelObtain2.readInt();
                                parcelObtain2.recycle();
                                parcelObtain.recycle();
                                this.b.f3896a.set(new Segment(0, 200, System.currentTimeMillis() - this.b.b, strawberry.c, i5, i2));
                            } catch (Throwable unused) {
                                i = i3;
                                this.b.f3896a.set(new Segment(-2003, 200, -1L, "", -1, i));
                            }
                        } catch (Throwable th2) {
                            parcelObtain2.recycle();
                            parcelObtain.recycle();
                            throw th2;
                        }
                    }
                    synchronized (this.b.c) {
                        this.b.c.notify();
                    }
                    if (q.f.a("s_t_d_ask", false)) {
                        try {
                            ((Gemini) gemini).c();
                        } catch (RemoteException e) {
                            e.printStackTrace();
                            return;
                        }
                    }
                }
                String str = Hydra.f3857a;
                lacerta = null;
                syrupA = Tangerine.a(gemini2.a().b);
                i4 = syrupA.f3897a;
                if (i4 != 0) {
                    this.b.f3896a.set(new Segment(i4, 200, -1L, "", -1, i2));
                } else {
                    Strawberry strawberry2 = syrupA.b;
                    parcelObtain = Parcel.obtain();
                    parcelObtain2 = Parcel.obtain();
                    parcelObtain.writeInterfaceToken(Hydra.f3857a);
                    gemini2.f3850a.transact(12, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    int i6 = parcelObtain2.readInt();
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                    this.b.f3896a.set(new Segment(0, 200, System.currentTimeMillis() - this.b.b, strawberry2.c, i6, i2));
                }
            } catch (Throwable unused2) {
                i3 = i2;
            }
            gemini2 = (Gemini) gemini;
            if (gemini2.b()) {
                parcelObtain3 = Parcel.obtain();
                parcelObtain4 = Parcel.obtain();
                parcelObtain3.writeInterfaceToken(Hydra.f3857a);
                parcelObtain3.writeInt(2000);
                gemini2.f3850a.transact(1, parcelObtain3, parcelObtain4, 0);
                parcelObtain4.readException();
                parcelObtain4.readInt();
                parcelObtain4.recycle();
                parcelObtain3.recycle();
                i2 = 1;
            } else {
                i2 = 0;
            }
        } catch (Throwable unused3) {
            i = -1;
            this.b.f3896a.set(new Segment(-2003, 200, -1L, "", -1, i));
            synchronized (this.b.c) {
                this.b.c.notify();
                if (q.f.a("s_t_d_ask", false)) {
                    ((Gemini) gemini).c();
                }
            }
        }
        gemini = lacerta;
        synchronized (this.b.c) {
            this.b.c.notify();
            if (q.f.a("s_t_d_ask", false)) {
                ((Gemini) gemini).c();
            }
        }
    }
}
