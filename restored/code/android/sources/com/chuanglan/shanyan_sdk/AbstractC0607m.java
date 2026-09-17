package com.chuanglan.shanyan_sdk;

import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import javax.net.ssl.HttpsURLConnection;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.m, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0607m {
    private void a() {
    }

    private void a(C0613s c0613s) {
    }

    public abstract void a(String str, String str2);

    protected abstract void a(byte[] bArr);

    public void a(HttpURLConnection httpURLConnection) throws Throwable {
        BufferedInputStream bufferedInputStream;
        BufferedInputStream bufferedInputStream2 = null;
        try {
            try {
                try {
                    int responseCode = httpURLConnection.getResponseCode();
                    if (responseCode >= 200 && responseCode < 300) {
                        a(new C0613s(httpURLConnection.getContentType(), httpURLConnection.getContentLength()));
                        bufferedInputStream = new BufferedInputStream(httpURLConnection.getInputStream());
                        try {
                            a(a(bufferedInputStream));
                            bufferedInputStream2 = bufferedInputStream;
                        } catch (Exception e) {
                            e = e;
                            bufferedInputStream2 = bufferedInputStream;
                            a(e.toString(), e.getClass().getSimpleName());
                            if (bufferedInputStream2 != null) {
                                bufferedInputStream2.close();
                            }
                            a();
                        } catch (Throwable th) {
                            th = th;
                            if (bufferedInputStream != null) {
                                try {
                                    bufferedInputStream.close();
                                } catch (IOException e2) {
                                    e2.printStackTrace();
                                }
                            }
                            a();
                            throw th;
                        }
                    } else {
                        a(responseCode + "", responseCode + "");
                    }
                    if (bufferedInputStream2 != null) {
                        bufferedInputStream2.close();
                    }
                } catch (Throwable th2) {
                    th = th2;
                    bufferedInputStream = null;
                }
            } catch (Exception e3) {
                e = e3;
            }
        } catch (IOException e4) {
            e4.printStackTrace();
        }
        a();
    }

    public void a(HttpsURLConnection httpsURLConnection) throws Throwable {
        BufferedInputStream bufferedInputStream;
        BufferedInputStream bufferedInputStream2 = null;
        try {
            try {
                try {
                    int responseCode = httpsURLConnection.getResponseCode();
                    if (responseCode >= 200 && responseCode < 300) {
                        a(new C0613s(httpsURLConnection.getContentType(), httpsURLConnection.getContentLength()));
                        bufferedInputStream = new BufferedInputStream(httpsURLConnection.getInputStream());
                        try {
                            a(a(bufferedInputStream));
                            bufferedInputStream2 = bufferedInputStream;
                        } catch (IOException e) {
                            e = e;
                            bufferedInputStream2 = bufferedInputStream;
                            a(e.toString(), e.getClass().getSimpleName());
                            if (bufferedInputStream2 != null) {
                                bufferedInputStream2.close();
                            }
                            a();
                        } catch (Throwable th) {
                            th = th;
                            if (bufferedInputStream != null) {
                                try {
                                    bufferedInputStream.close();
                                } catch (IOException e2) {
                                    e2.printStackTrace();
                                }
                            }
                            a();
                            throw th;
                        }
                    } else {
                        a("Bad Response Code" + responseCode, responseCode + "");
                    }
                    if (bufferedInputStream2 != null) {
                        bufferedInputStream2.close();
                    }
                } catch (Throwable th2) {
                    th = th2;
                    bufferedInputStream = null;
                }
            } catch (IOException e3) {
                e = e3;
            }
        } catch (IOException e4) {
            e4.printStackTrace();
        }
        a();
    }

    private byte[] a(InputStream inputStream) throws Throwable {
        ByteArrayOutputStream byteArrayOutputStream;
        ByteArrayOutputStream byteArrayOutputStream2 = null;
        try {
            try {
                byteArrayOutputStream = new ByteArrayOutputStream();
                try {
                    byte[] bArr = new byte[2048];
                    while (true) {
                        int i = inputStream.read(bArr, 0, 2048);
                        if (i != -1) {
                            byteArrayOutputStream.write(bArr, 0, i);
                        } else {
                            try {
                                break;
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                        }
                    }
                    byteArrayOutputStream.flush();
                    byteArrayOutputStream.close();
                } catch (Exception e2) {
                    e = e2;
                    byteArrayOutputStream2 = byteArrayOutputStream;
                    e.printStackTrace();
                    if (byteArrayOutputStream2 != null) {
                        try {
                            byteArrayOutputStream2.flush();
                            byteArrayOutputStream2.close();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                    }
                    byteArrayOutputStream = byteArrayOutputStream2;
                } catch (Throwable th) {
                    th = th;
                    byteArrayOutputStream2 = byteArrayOutputStream;
                    if (byteArrayOutputStream2 != null) {
                        try {
                            byteArrayOutputStream2.flush();
                            byteArrayOutputStream2.close();
                        } catch (Exception e4) {
                            e4.printStackTrace();
                        }
                    }
                    throw th;
                }
            } catch (Exception e5) {
                e = e5;
            }
            return byteArrayOutputStream.toByteArray();
        } catch (Throwable th2) {
            th = th2;
        }
    }
}
