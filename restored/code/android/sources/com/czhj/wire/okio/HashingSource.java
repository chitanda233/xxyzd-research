package com.czhj.wire.okio;

import com.baidu.mobads.sdk.internal.bz;
import java.io.IOException;
import java.security.InvalidKeyException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import javax.crypto.Mac;
import javax.crypto.spec.SecretKeySpec;

/* JADX INFO: loaded from: classes2.dex */
public final class HashingSource extends ForwardingSource {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final MessageDigest f2384a;
    private final Mac b;

    private HashingSource(Source source, ByteString byteString, String str) {
        super(source);
        try {
            Mac mac = Mac.getInstance(str);
            this.b = mac;
            mac.init(new SecretKeySpec(byteString.toByteArray(), str));
            this.f2384a = null;
        } catch (InvalidKeyException e) {
            throw new IllegalArgumentException(e);
        } catch (NoSuchAlgorithmException unused) {
            throw new AssertionError();
        }
    }

    private HashingSource(Source source, String str) {
        super(source);
        try {
            this.f2384a = MessageDigest.getInstance(str);
            this.b = null;
        } catch (NoSuchAlgorithmException unused) {
            throw new AssertionError();
        }
    }

    public static HashingSource hmacSha1(Source source, ByteString byteString) {
        return new HashingSource(source, byteString, "HmacSHA1");
    }

    public static HashingSource hmacSha256(Source source, ByteString byteString) {
        return new HashingSource(source, byteString, "HmacSHA256");
    }

    public static HashingSource md5(Source source) {
        return new HashingSource(source, bz.f456a);
    }

    public static HashingSource sha1(Source source) {
        return new HashingSource(source, "SHA-1");
    }

    public static HashingSource sha256(Source source) {
        return new HashingSource(source, "SHA-256");
    }

    public final ByteString hash() {
        MessageDigest messageDigest = this.f2384a;
        return ByteString.of(messageDigest != null ? messageDigest.digest() : this.b.doFinal());
    }

    @Override // com.czhj.wire.okio.ForwardingSource, com.czhj.wire.okio.Source
    public long read(Buffer buffer, long j) throws IOException {
        long j2 = super.read(buffer, j);
        if (j2 != -1) {
            long j3 = buffer.c - j2;
            long j4 = buffer.c;
            Segment segment = buffer.b;
            while (j4 > j3) {
                segment = segment.i;
                j4 -= (long) (segment.e - segment.d);
            }
            while (j4 < buffer.c) {
                int i = (int) ((((long) segment.d) + j3) - j4);
                MessageDigest messageDigest = this.f2384a;
                if (messageDigest != null) {
                    messageDigest.update(segment.c, i, segment.e - i);
                } else {
                    this.b.update(segment.c, i, segment.e - i);
                }
                j4 += (long) (segment.e - segment.d);
                segment = segment.h;
                j3 = j4;
            }
        }
        return j2;
    }
}
