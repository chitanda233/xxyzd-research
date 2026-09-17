package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.Intent;
import android.os.Process;
import android.text.TextUtils;
import android.util.Base64;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.security.InvalidAlgorithmParameterException;
import java.security.Key;
import java.security.KeyPairGenerator;
import java.security.KeyStore;
import java.security.KeyStoreException;
import java.security.NoSuchAlgorithmException;
import java.security.NoSuchProviderException;
import java.security.Provider;
import java.security.Security;
import java.security.UnrecoverableKeyException;
import java.security.cert.CertificateException;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Tangerine {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3898a = Cinstanceof.a(Cinstanceof.E0);

    public static Segment a() {
        String name;
        long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            Method method = Class.forName(Cinstanceof.a(Cinstanceof.F0)).getMethod(Cinstanceof.a(Cinstanceof.G0), null);
            method.setAccessible(true);
            method.invoke(null, null);
            Provider[] providers = Security.getProviders();
            if (providers == null) {
                return Segment.a(-1201);
            }
            int length = providers.length;
            int i = 0;
            while (true) {
                if (i < length) {
                    name = providers[i].getName();
                    if (name != null && name.startsWith(f3898a)) {
                        break;
                    }
                    i++;
                } else {
                    name = null;
                    break;
                }
            }
            if (TextUtils.isEmpty(name)) {
                return Segment.a(-1202);
            }
            boolean z = name.split("\\.").length > 1;
            try {
                KeyStore keyStore = KeyStore.getInstance(name);
                keyStore.load(null);
                int iMyUid = Process.myUid();
                try {
                    if (keyStore.getCertificate("dddd" + iMyUid) == null) {
                        try {
                            KeyPairGenerator keyPairGenerator = KeyPairGenerator.getInstance(com.alipay.sdk.m.p.d.f334a, name);
                            try {
                                try {
                                    keyPairGenerator.initialize(Solar.a("dddd" + iMyUid + Cinstanceof.a(Cinstanceof.H0), z ? 16 : 4).a("SHA-256").b("PSS").a());
                                    try {
                                        keyPairGenerator.generateKeyPair();
                                    } catch (Throwable unused) {
                                    }
                                } catch (InvalidAlgorithmParameterException unused2) {
                                    return Segment.a(-1701);
                                }
                            } catch (ClassNotFoundException unused3) {
                                return Segment.a(-1601);
                            } catch (IllegalAccessException unused4) {
                                return Segment.a(-1603);
                            } catch (InstantiationException unused5) {
                                return Segment.a(-1605);
                            } catch (NoSuchMethodException unused6) {
                                return Segment.a(-1602);
                            } catch (InvocationTargetException unused7) {
                                return Segment.a(-1604);
                            }
                        } catch (NoSuchAlgorithmException unused8) {
                            return Segment.a(-1501);
                        } catch (NoSuchProviderException unused9) {
                            return Segment.a(-1502);
                        }
                    }
                } catch (Throwable unused10) {
                }
                if (z) {
                    try {
                        return new Segment(0, 100, System.currentTimeMillis() - jCurrentTimeMillis, new Strawberry(keyStore.getCertificateChain("dddd" + iMyUid)).c, -1, -2);
                    } catch (KeyStoreException e) {
                        e.printStackTrace();
                    }
                } else {
                    try {
                        Key key = keyStore.getKey("dddd" + iMyUid, Cinstanceof.a(Cinstanceof.I0).toCharArray());
                        if (key != null) {
                            Syrup syrupA = a(key.getEncoded());
                            int i2 = syrupA.f3897a;
                            if (i2 != 0) {
                                return Segment.a(i2);
                            }
                            Strawberry strawberry = syrupA.b;
                            if (q.f.a("s_t_d_entry", false)) {
                                try {
                                    keyStore.deleteEntry("dddd" + iMyUid);
                                } catch (Throwable unused11) {
                                }
                            }
                            return new Segment(0, 100, System.currentTimeMillis() - jCurrentTimeMillis, strawberry.c, -1, -2);
                        }
                    } catch (KeyStoreException unused12) {
                        return Segment.a(-1801);
                    } catch (NoSuchAlgorithmException unused13) {
                        return Segment.a(-1802);
                    } catch (UnrecoverableKeyException unused14) {
                        return Segment.a(-1803);
                    }
                }
                return Segment.a(-1901);
            } catch (IOException unused15) {
                return Segment.a(-1303);
            } catch (KeyStoreException unused16) {
                return Segment.a(-1301);
            } catch (NoSuchAlgorithmException unused17) {
                return Segment.a(-1304);
            } catch (CertificateException unused18) {
                return Segment.a(-1302);
            }
        } catch (ClassNotFoundException unused19) {
            return Segment.a(-1104);
        } catch (IllegalAccessException unused20) {
            return Segment.a(-1103);
        } catch (NoSuchMethodException unused21) {
            return Segment.a(-1102);
        } catch (InvocationTargetException unused22) {
            return Segment.a(-1101);
        }
    }

    public static Segment a(Context context) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        Intent intent = new Intent();
        intent.setAction(Cinstanceof.a(Cinstanceof.J0));
        intent.setPackage(Cinstanceof.a(Cinstanceof.K0));
        Object obj = new Object();
        AtomicReference atomicReference = new AtomicReference();
        atomicReference.set(new Segment(-2001, 200, -1L, "", -1, -1));
        if (context.getApplicationContext().bindService(intent, new Sultana(atomicReference, jCurrentTimeMillis, obj), 1)) {
            synchronized (obj) {
                try {
                    obj.wait(5000L);
                } catch (InterruptedException unused) {
                }
            }
        } else {
            atomicReference.set(new Segment(-2002, 200, -1L, "", -1, -1));
        }
        return (Segment) atomicReference.get();
    }

    public static Syrup a(byte[] bArr) {
        if (bArr == null) {
            return new Syrup(AVMDLDataLoader.AVMDLErrorIsStatusCodeMoreThan500, null);
        }
        if (bArr.length < 4) {
            return new Syrup(AVMDLDataLoader.AVMDLErrorIsStatusCodeMoreThan500, null);
        }
        byte[] bArr2 = new byte[4];
        System.arraycopy(bArr, 0, bArr2, 0, 4);
        int i = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            i += (bArr2[i2] & 255) << (i2 * 8);
        }
        if (i > 1048576) {
            return new Syrup(-3003, null);
        }
        byte[] bArr3 = new byte[i];
        int i3 = i + 4;
        if (bArr.length < i3) {
            return new Syrup(-3004, null);
        }
        System.arraycopy(bArr, 4, bArr3, 0, i);
        Strawberry strawberry = new Strawberry(new String(bArr3));
        int length = bArr.length - i3;
        if (length != 0) {
            byte[] bArr4 = new byte[length];
            System.arraycopy(bArr, i3, bArr4, 0, length);
            Base64.encodeToString(bArr4, 2);
            return new Syrup(0, strawberry);
        }
        return new Syrup(-3005, null);
    }
}
